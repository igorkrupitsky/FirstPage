Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form1

    Private Sub btnFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrom.Click
        fldFrom.ShowDialog()
        txtFrom.Text = fldFrom.SelectedPath
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim sFromPath As String = txtFrom.Text
        If Not Directory.Exists(sFromPath) Then
            MsgBox("Folder does not exist")
            Exit Sub
        End If

        txtOutput.Text = ""
        txtOutput.Text += "Starting..." & vbCrLf
        ProccessFolder(sFromPath)
        txtOutput.Text += "Done!"
    End Sub


    Sub ProccessFolder(ByVal sFolderPath As String)

        btnProcess.Enabled = False

        Dim bOutputfileAlreadyExists As Boolean = False
        Dim oFolderInfo As New System.IO.DirectoryInfo(sFolderPath)

		txtOutput.Text += "Processing folder: " & sFolderPath & vbCrLf

		Dim oFiles As String() = Directory.GetFiles(sFolderPath)
		ProgressBar1.Maximum = oFiles.Length

		For i As Integer = 0 To oFiles.Length - 1
			Dim sInFilePath As String = oFiles(i)
			Dim oFileInfo As New FileInfo(sInFilePath)
			Dim sOutFilePath As String = sFolderPath & "\" & oFileInfo.Name & "_processed.pdf"
			Dim sExt As String = UCase(oFileInfo.Extension).Substring(1, 3)
			Dim bError As Boolean = False

			If sExt = "PDF" Then
				txtOutput.Text += "Processing file: " & sInFilePath & vbCrLf

				'Deleting previous temp file
				If IO.File.Exists(sOutFilePath) Then
					Try
						IO.File.Delete(sOutFilePath)
					Catch ex As Exception
						txtOutput.Text += "Error deleting previous temp file: " & sOutFilePath & vbTab & ex.Message & vbCrLf
						bError = True
					End Try
				End If

				'Processing File
				If bError = False Then
					Try
                        'ProcessPdf(sInFilePath, sOutFilePath)
                        AddPdf(sInFilePath, sOutFilePath, selPages.Text)
					Catch ex As Exception
						txtOutput.Text += "Error processing: " & sInFilePath & vbTab & ex.Message & vbCrLf
						bError = True
					End Try
				End If

				'Deleting current PDF file
				If bError = False And IO.File.Exists(sInFilePath) Then
					Try
						IO.File.Delete(sInFilePath)
					Catch ex As Exception
						txtOutput.Text += "Error deleting current file: " & sInFilePath & vbTab & ex.Message & vbCrLf
						bError = True
					End Try
				End If

				'renaming temp file
				If bError = False And IO.File.Exists(sOutFilePath) Then
					Try
						IO.File.Move(sOutFilePath, sInFilePath)
					Catch ex As Exception
						txtOutput.Text += "Error renaming temp file from: " & sOutFilePath & " to " & sInFilePath & vbTab & ex.Message & vbCrLf
					End Try
				End If

				'Cleanup after error: deleting temp file
				If bError And IO.File.Exists(sOutFilePath) Then
					Try
						IO.File.Delete(sOutFilePath)
					Catch ex As Exception
						txtOutput.Text += "Error deleting temp file: " & sOutFilePath & vbTab & ex.Message & vbCrLf
						bError = True
					End Try
				End If

			End If

			ProgressBar1.Value = i
		Next

		ProgressBar1.Value = 0
		btnProcess.Enabled = True

		Dim oFolders As String() = Directory.GetDirectories(sFolderPath)
		For i As Integer = 0 To oFolders.Length - 1
			Dim sChildFolder As String = oFolders(i)
			Dim iPos As Integer = sChildFolder.LastIndexOf("\")
			Dim sFolderName As String = sChildFolder.Substring(iPos + 1)
			ProccessFolder(sChildFolder)
		Next

    End Sub

    Sub AddPdf(ByVal sInFilePath As String, ByVal sOutFilePath As String, ByVal iIncludePages As Integer)

        Dim oPdfDoc As New iTextSharp.text.Document()
        Dim oPdfWriter As PdfWriter = PdfWriter.GetInstance(oPdfDoc, New FileStream(sOutFilePath, FileMode.Create))
        oPdfDoc.Open()

        Dim oDirectContent As iTextSharp.text.pdf.PdfContentByte = oPdfWriter.DirectContent
        Dim oPdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(sInFilePath)
        Dim iNumberOfPages As Integer = oPdfReader.NumberOfPages
        Dim iPage As Integer = 0

        Do While (iPage < iNumberOfPages)
            iPage += 1

            If iPage <= iIncludePages Then
                oPdfDoc.SetPageSize(oPdfReader.GetPageSizeWithRotation(iPage))
                oPdfDoc.NewPage()

                Dim oPdfImportedPage As iTextSharp.text.pdf.PdfImportedPage = oPdfWriter.GetImportedPage(oPdfReader, iPage)
                Dim iRotation As Integer = oPdfReader.GetPageRotation(iPage)
                If (iRotation = 90) Or (iRotation = 270) Then
                    oDirectContent.AddTemplate(oPdfImportedPage, 0, -1.0F, 1.0F, 0, 0, oPdfReader.GetPageSizeWithRotation(iPage).Height)
                Else
                    oDirectContent.AddTemplate(oPdfImportedPage, 1.0F, 0, 0, 1.0F, 0, 0)
                End If
            End If

        Loop

        oPdfDoc.Close()
        oPdfWriter.Close()

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        selPages.SelectedIndex = 0

    End Sub
End Class
