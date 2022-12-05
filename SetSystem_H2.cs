using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace Revit_SystemSetter
{
    // EL systems
    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if(P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Main distribution systems");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H2");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H201 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Main distribution systems FR");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H201");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H202 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Main distribution systems FR EI+");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H202");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H203 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Main distribution systems (Metal)");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H203");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    // Voids

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H2V1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Provisions of Openings EL (Existing)");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H2V1");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H2V2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Provisions of Openings EL (New)");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H2V2");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H2V3 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Provisions of Openings EL (Cancelled)");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H2V3");
                }

                //System.Windows.Forms.MessageBox.Show(R);
                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());

            }

            trans.Commit();
            return Result.Succeeded;
        }
    }

    // ESS

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_J2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Communication systems");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("J2");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_J201 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Communication systems FR");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("J201");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    // EL + ESS

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_HJ201 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Main distribution systems (EL+ESS)");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("HJ201");
                }



            }

            trans.Commit();
            return Result.Succeeded;
        }


    }


    // UATS
    [Transaction(TransactionMode.Manual)]
    public class SetSystem_J401 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Fire alarm system");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("J401");
                }

            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    // ESS-AS
    [Transaction(TransactionMode.Manual)]
    public class SetSystem_J402 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {

                    P[0].Set("Intrusion system");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {

                    P1[0].Set("J402");
                }

            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    // ESS-PK
    [Transaction(TransactionMode.Manual)]
    public class SetSystem_J403 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {

                    P[0].Set("Access control system");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {

                    P1[0].Set("J403");
                }

            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    // ESS-VN
    [Transaction(TransactionMode.Manual)]
    public class SetSystem_J404 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {

                    P[0].Set("Video surveillance system");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {

                    P1[0].Set("J404");
                }

            }

            trans.Commit();
            return Result.Succeeded;
        }


    }


    // EL Lights

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H501 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("General lighting system");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H501");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H502 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Emergency lighting system");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H502");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }


    // EL Lightning

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H701 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Lightning Protection");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H701");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H702 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Lightning Protection (Existing)");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H702");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }

    [Transaction(TransactionMode.Manual)]
    public class SetSystem_H703 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            Transaction trans = new Transaction(doc);
            trans.Start("Epic System Change");

            var selection = uidoc.Selection.GetElementIds();

            foreach (ElementId id in selection)
            {
                Element E = uidoc.Document.GetElement(id);
                var P = E.GetParameters("MC System Name");

                if (P.Count > 0)
                {
                    //var R = P[0].AsString();
                    P[0].Set("Earthing System");
                }

                var P1 = E.GetParameters("MC System Code");

                if (P1.Count > 0)
                {
                    //var R = P[0].AsString();
                    P1[0].Set("H703");
                }


                //System.Windows.Forms.MessageBox.Show(R);

                //System.Windows.Forms.MessageBox.Show(P[0].Set("ChangeTest").ToString());


            }

            trans.Commit();
            return Result.Succeeded;
        }


    }


}
