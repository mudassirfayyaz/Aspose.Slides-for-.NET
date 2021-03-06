Imports System
Imports Aspose.Slides.SlideShow
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Slides.Transitions
    Public Class SimpleSlideTransitions
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations_Transitions()

            ' Instantiate Presentation class that represents a presentation file
            Using pres As New Presentation(dataDir & Convert.ToString("SimpleSlideTransitions.pptx"))

                ' Apply circle type transition on slide 1
                pres.Slides(0).SlideShowTransition.Type = TransitionType.Circle

                ' Apply comb type transition on slide 2
                pres.Slides(1).SlideShowTransition.Type = TransitionType.Comb

                ' Write the presentation to disk
                pres.Save(dataDir & Convert.ToString("SampleTransition_out.pptx"), SaveFormat.Pptx)
            End Using
        End Sub
    End Class
End Namespace