﻿using AD.Core.Models;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
namespace AD.Core
{
    public static class AppContextRevit
    {


        public static ModelDoc GetDocument(ExternalCommandData commandData)
        {

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document document = uidoc.Document;

            View activeView = uidoc.ActiveView;
            return new ModelDoc()
            {
                AdUiDoc = uidoc,
                AdDocument = document,
                ActiveView = activeView,
            };
        }
    }
}
