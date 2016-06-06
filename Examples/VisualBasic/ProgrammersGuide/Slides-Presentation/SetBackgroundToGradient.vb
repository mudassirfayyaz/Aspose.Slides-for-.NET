'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides.Export
Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx


Namespace VisualBasic.Slides
    Public Class SetBackgroundToGradient
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            'Instantiate the Presentation class that represents the presentation file
            Using pres As New Presentation(dataDir & "SetBackgroundToGradient.pptx")

                'Apply Gradiant effect to the Background
                pres.Slides(0).Background.Type = BackgroundType.OwnBackground
                pres.Slides(0).Background.FillFormat.FillType = FillType.Gradient
                pres.Slides(0).Background.FillFormat.GradientFormat.TileFlip = TileFlip.FlipBoth

                'Write the presentation to disk
                pres.Save(dataDir & "ContentBG_Grad.pptx", SaveFormat.Pptx)

            End Using

        End Sub
    End Class
End Namespace