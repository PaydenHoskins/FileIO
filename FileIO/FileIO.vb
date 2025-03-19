'Payden Hoskins
'RCET 2265
'FileIO
'Spring2025

Option Explicit On
Option Compare Text
Option Strict On

Module FileIO

    Sub Main()
        WriteToFile()
    End Sub
    ''' <summary>
    ''' Writes a predetermined string to the file that is being called. Replaces any previous lines before it.
    ''' </summary>
    Sub WriteToFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, "Follow The White Rabbit...")

        FileClose(1)

    End Sub
    ''' <summary>
    ''' Writes mutiple lines without deleating previous data in the .txt file.
    ''' </summary>
    Sub AppendAFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Append)
        For i = 1 To 10
            Write(1, "You are my sunshine, my only sunshine.")
        Next

        FileClose(1)

    End Sub

End Module
