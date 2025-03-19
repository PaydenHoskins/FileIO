'Payden Hoskins
'RCET 2265
'FileIO
'Spring2025

Option Explicit On
Option Compare Text
Option Strict On

Module FileIO

    Sub Main()
        'Commented out so we dont run them evr time.
        'WriteToFile()
        'AppendAFile()

        ReadFromFile()

    End Sub
    ''' <summary>
    ''' Writes a predetermined string to the file that is being called. Replaces any previous lines before it.
    ''' </summary>
    Sub WriteToFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, " Follow The White Rabbit... ")

        FileClose(1)

    End Sub
    ''' <summary>
    ''' Writes mutiple lines without deleating previous data in the .txt file.
    ''' </summary>
    Sub AppendAFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Append)
        For i = 1 To 10
            Write(1, " You are my sunshine, my only sunshine. ")
        Next

        FileClose(1)

    End Sub

    Sub ReadFromFile()
        Dim currentRecord As String
        Dim fileName As String = "MyCoolFile.txt"
        Try
            FileOpen(1, fileName, OpenMode.Input)
            Input(1, currentRecord)

            FileClose(1)
            Console.WriteLine(currentRecord)
        Catch ex As Exception
            MsgBox($"oops! File{fileName} is not found.")
        End Try

    End Sub
End Module
