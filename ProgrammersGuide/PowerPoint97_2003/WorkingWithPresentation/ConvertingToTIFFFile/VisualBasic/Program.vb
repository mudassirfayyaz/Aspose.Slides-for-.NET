'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.Export

Namespace ConvertingToTIFFFile
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")



			' 1.
			' Save to TIFF using default oprtions.
			'Instantiate a Presentation object that represents a PPT file
			Dim pres As New Presentation(dataDir & "demo.ppt")

			'Saving the presentation to TIFF document
			pres.Save(dataDir & "demo1.tiff", Aspose.Slides.Export.SaveFormat.Tiff)



			' 2.
			' Save to TIFF with customized image size using TiffOptions class.
			'Instantiate the TiffOptions class
			Dim opts As New Aspose.Slides.Export.TiffOptions()

			'Setting compression type
			opts.CompressionType = TiffCompressionTypes.Default

			'Compression Types

			'Default - Specifies the default compression scheme (LZW).
			'None - Specifies no compression.
			'CCITT3
			'CCITT4
			'LZW
			'RLE

			'Depth � depends on the compression type and cannot be set manually.
			'Resolution unit � is always equal to "2" (dots per inch)

			'Setting image DPI
			opts.DpiX = 200
			opts.DpiY = 100

			'Set Image Size
			opts.ImageSize = New Size(1728, 1078)


			'Save the presentation to TIFF with specified image size
			pres.Save(dataDir & "demo2.tiff", Aspose.Slides.Export.SaveFormat.Tiff, opts)
		End Sub
	End Class
End Namespace