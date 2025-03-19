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

    Sub WriteToFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, "Hello Moto.")

        FileClose(1)

    End Sub

End Module
