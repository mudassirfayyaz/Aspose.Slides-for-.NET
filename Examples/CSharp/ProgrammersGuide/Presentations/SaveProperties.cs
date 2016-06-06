//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/


namespace CSharp.Presentations
{
    public class SaveProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Presentations();

            //Instantiate a Presentation object that represents a PPT file
            Presentation presentation = new Presentation();

            //....do some work here.....

            //Setting access to document properties in password protected mode
            presentation.ProtectionManager.EncryptDocumentProperties = false;

            //Setting Password
            presentation.ProtectionManager.Encrypt("pass");

            //Save your presentation to a file
            presentation.Save(dataDir + "Password Protected Presentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}