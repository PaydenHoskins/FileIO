'Payden Hoskins
'RCET 2265
'FileIO
'Spring2025

Option Explicit On
Option Compare Text
Option Strict On

Module FileIO

    Sub Main()

    End Sub

    Sub WriteToFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        FileClose(1)

    End Sub

End Module
