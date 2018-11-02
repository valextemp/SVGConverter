using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SVGConverter_BL
{
    public class Converter
    {
        readonly string DataChangeStr = "var v = parseFloat(args[0]); " +
        "if (v - Math.floor(v) != 0 && !isNaN(v)) " +
        "{ " +
            "var res; " +
            "if (Math.abs(v) >= 1000) " +
            "{ " +
                "res = v.toFixed(); " +
            "} " +
            "else if (Math.abs(v) >= 100) " +
            "{ " +
                "res = v.toFixed(1); " +
            "} " +
            "else if (Math.abs(v) >= 10) " +
            "{ " +
                "res = v.toFixed(2); " +
            "} " +
            "else " +
            "{ " +
                "res = v.toFixed(3); " +
            "} " +
            "args[0] = res + ' ' + this.__units[0]; " +
            "this.getDomElement().find('text').text(args[0]); " +
        "}";

        public void CharngeAttributesInFile(string fileNameFullPath, bool changingFlag = true, bool changeFlag = true)
        {
            if (!File.Exists(fileNameFullPath))
            {
                return;
            }

            XDocument xDoc = XDocument.Load(fileNameFullPath);
            XNamespace nsa = "http://schemas.microsoft.com/visio/2003/SVGExtensions/";

            IEnumerable<XElement> svgElements =
                 from svgElement in xDoc.Descendants(nsa + "cp")
                 where (string)svgElement.Attribute(nsa + "val") == "ISPValue"
                 select svgElement;

            XElement myParent;
            XElement dtc, dtc1;
            string sAttribValue;

            ////////////////////////////////////////////////////////
            foreach (XElement el in svgElements)
            {
                myParent = el.Parent;

                if (changingFlag)
                {
                    IEnumerable<XElement> dtChangings =
                    from dtChanging in myParent.Descendants(nsa + "cp")
                    where (string)dtChanging.Attribute(nsa + "lbl") == "DataChanging"
                    select dtChanging;

                    if (dtChangings != null)
                    {
                        dtc = dtChangings.First();
                        sAttribValue = (string)dtc.Attribute(nsa + "val");
                        if (sAttribValue != null)
                        {
                            if (sAttribValue.Contains("var v = parseFloat(args[0]);"))
                            {
                                Console.WriteLine("str ok");
                                //dtc.Attribute(nsa + "val").Value = "";
                                dtc.SetAttributeValue(nsa + "val", DataChangeStr);
                            }
                        }
                    }

                }

                ////////////////////////////////////////////////////////////////////////////////////
                if (changingFlag)
                {
                    IEnumerable<XElement> dtChanges =
                    from dtChange in myParent.Descendants(nsa + "cp")
                    where (string)dtChange.Attribute(nsa + "lbl") == "DataChange"
                    select dtChange;

                    if (dtChanges != null)
                    {
                        dtc1 = dtChanges.First();
                        sAttribValue = (string)dtc1.Attribute(nsa + "val");
                        if (sAttribValue != null)
                        {
                            //Console.WriteLine("DataChange attrib exist = " + sAttribValue);
                            //dtc1.Attribute(nsa + "val").Value = @"var v = parseFloat(args[0]); &#10;if (v-Math.floor(v)!=0 &#38;&#38; !isNaN(v)) {&#10;var res;&#10;if (Math.abs(v)&#62;=1000) {&#10;res = v.toFixed();&#10;} else if (Math.abs(v)&#62;=100) {&#10;res = v.toFixed(1);&#10;} else if (Math.abs(v)&#62;=10) {&#10;res = v.toFixed(2);&#10;} else {&#10;res = v.toFixed(3);&#10;} &#10;args[0] = res + &#39; &#39; + this.__units[0];&#10;this.getDomElement().find(&#39;text&#39;).text(args[0]);}";
                            dtc1.SetAttributeValue(nsa + "val", DataChangeStr);
                            //@"var v = parseFloat(args[0]); &#10;if (v-Math.floor(v)!=0 &#38;&#38; !isNaN(v)) {&#10;var res;&#10;if (Math.abs(v)&#62;=1000) {&#10;res = v.toFixed();&#10;} else if (Math.abs(v)&#62;=100) {&#10;res = v.toFixed(1);&#10;} else if (Math.abs(v)&#62;=10) {&#10;res = v.toFixed(2);&#10;} else {&#10;res = v.toFixed(3);&#10;} &#10;args[0] = res + &#39; &#39; + this.__units[0];&#10;this.getDomElement().find(&#39;text&#39;).text(args[0]);}"
                        }
                        else
                        {
                            dtc1.SetAttributeValue(nsa + "val", DataChangeStr);
                        }
                    }
                }

            }

        }


        //FileInfo[]
        public void CharngeAttributesInFiles(FileInfo[] files, bool changingFlag = true, bool changeFlag = true)
        {
            foreach (var item in files)
            {
                CharngeAttributesInFile(item.FullName, changingFlag, changeFlag);
            }
        }

        public void CharngeAttributesInFiles(BindingList<SvgFile> files, bool changingFlag = true, bool changeFlag = true)
        {
            foreach (var item in files)
            {
                //////////////////////////////////////////////////
                //CharngeAttributesInFile(item.SvgFullFileName, changingFlag, changeFlag);
                /////////////////////////////////////////////////////

                if (!File.Exists(item.SvgFullFileName))
                {
                    return;
                }

                item.StatusWork();
                item.ResetCounts();
                try
                {
                    XDocument xDoc = XDocument.Load(item.SvgFullFileName);
                    XNamespace nsa = "http://schemas.microsoft.com/visio/2003/SVGExtensions/";

                    IEnumerable<XElement> svgElements =
                         from svgElement in xDoc.Descendants(nsa + "cp")
                         where (string)svgElement.Attribute(nsa + "val") == "ISPValue"
                         select svgElement;

                    XElement myParent;
                    XElement dtc, dtc1;
                    string sAttribValue;

                    if (svgElements==null)
                    {
                        item.StatusReady();
                        return;
                    }
                    ////////////////////////////////////////////////////////
                    foreach (XElement el in svgElements)
                    {
                        myParent = el.Parent;

                        if (changingFlag)
                        {
                            IEnumerable<XElement> dtChangings =
                            from dtChanging in myParent.Descendants(nsa + "cp")
                            where (string)dtChanging.Attribute(nsa + "lbl") == "DataChanging"
                            select dtChanging;

                            if ((dtChangings != null) && (dtChangings.Count()>0))
                            {
                                dtc = dtChangings.First();
                                sAttribValue = (string)dtc.Attribute(nsa + "val");
                                if (sAttribValue != null)
                                {
                                    if (sAttribValue.Contains("var v = parseFloat(args[0]);"))
                                    {
                                        Console.WriteLine("str ok");
                                        //dtc.Attribute(nsa + "val").Value = "";
                                        dtc.SetAttributeValue(nsa + "val", DataChangeStr);
                                        item.AddChangingCount();
                                    }
                                }
                            }

                        }

                        ////////////////////////////////////////////////////////////////////////////////////
                        if (changingFlag)
                        {
                            IEnumerable<XElement> dtChanges =
                            from dtChange in myParent.Descendants(nsa + "cp")
                            where (string)dtChange.Attribute(nsa + "lbl") == "DataChange"
                            select dtChange;

                            if ((dtChanges != null) && (dtChanges.Count()>0))
                            {
                                dtc1 = dtChanges.First();
                                sAttribValue = (string)dtc1.Attribute(nsa + "val");
                                if (sAttribValue != null)
                                {
                                    //Console.WriteLine("DataChange attrib exist = " + sAttribValue);
                                    //dtc1.Attribute(nsa + "val").Value = @"var v = parseFloat(args[0]); &#10;if (v-Math.floor(v)!=0 &#38;&#38; !isNaN(v)) {&#10;var res;&#10;if (Math.abs(v)&#62;=1000) {&#10;res = v.toFixed();&#10;} else if (Math.abs(v)&#62;=100) {&#10;res = v.toFixed(1);&#10;} else if (Math.abs(v)&#62;=10) {&#10;res = v.toFixed(2);&#10;} else {&#10;res = v.toFixed(3);&#10;} &#10;args[0] = res + &#39; &#39; + this.__units[0];&#10;this.getDomElement().find(&#39;text&#39;).text(args[0]);}";
                                    dtc1.SetAttributeValue(nsa + "val", DataChangeStr);
                                    item.AddChangeCount();
                                    //@"var v = parseFloat(args[0]); &#10;if (v-Math.floor(v)!=0 &#38;&#38; !isNaN(v)) {&#10;var res;&#10;if (Math.abs(v)&#62;=1000) {&#10;res = v.toFixed();&#10;} else if (Math.abs(v)&#62;=100) {&#10;res = v.toFixed(1);&#10;} else if (Math.abs(v)&#62;=10) {&#10;res = v.toFixed(2);&#10;} else {&#10;res = v.toFixed(3);&#10;} &#10;args[0] = res + &#39; &#39; + this.__units[0];&#10;this.getDomElement().find(&#39;text&#39;).text(args[0]);}"
                                }
                                else
                                {
                                    dtc1.SetAttributeValue(nsa + "val", DataChangeStr);
                                    item.AddChangeCount();
                                }
                            }
                        }

                    }
                    xDoc.Save(item.SvgFullFileName);
                    item.StatusReady();
                }
                catch (Exception e)
                {
                    string err = e.ToString();
                    item.StatusError();
                }


                Task.Delay(10).Wait();
                //////////////////////////////////////////////////////////////////////
            }
        }


    }
}
