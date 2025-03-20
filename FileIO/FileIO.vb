Option Explicit On
Option Compare Text
Option Strict On
'Payden Hoskins
'RCET 2265
'FileIO
'Spring2025

Imports System.IO

Module FileIO

    Sub Main()
        'Commented out so we dont run them every time.
        'WriteToFile()
        'AppendAFile()

        'ReadFromFile()

        DocExample()

        ReadAllRecords()
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
            Do Until EOF(1) 'Repeats till we have read all the file data.
                Input(1, currentRecord)
                Console.WriteLine(currentRecord)
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox($"oops! File{fileName} is not found.")
        End Try

    End Sub

    Sub DocExample()
        ' Open file for output.
        FileOpen(1, "TestFile.txt", OpenMode.Output)
        ' Print text to the file. The quotation marks will be in the display.
        Write(1, "This is a test.")
        ' Go to the next line.
        WriteLine(1)
        ' Skip a line.
        WriteLine(1)
        ' Print in two print zones. You will see commas and quotation marks
        ' in the output file.
        WriteLine(1, "Zone 1", SPC(10), "Zone 2")
        ' Build a longer string before calling WriteLine.
        WriteLine(1, "Hello" & "  " & "World")
        ' Include five leading spaces.
        WriteLine(1, SPC(5), "Leading spaces")
        ' Print a word starting at column 10.
        WriteLine(1, TAB(10), "Hello")

        ' Assign Boolean and Date values.
        Dim aBool As Boolean
        Dim aDate As DateTime
        aBool = False
        aDate = DateTime.Parse("February 12, 1969")

        ' Dates and Booleans are translated using locale settings of 
        ' your system.
        WriteLine(1, aBool & " is a Boolean value.")
        WriteLine(1, aDate & " is a date.")

        'Payden H. code add in
        WriteLine(1)
        Write(1, aBool)
        Write(1, aDate)

        ' Close the file.
        FileClose(1)
    End Sub

    Sub ReadAllRecords()
        Dim currentString As String
        Dim count As Single
        Try
            FileOpen(1, "TestFile.txt", OpenMode.Input)
            Do Until EOF(1)
                count += 1
                Input(1, currentString)
                Console.WriteLine($"Record {CStr(count).PadLeft(3)} is {CStr(Len(currentString)).PadLeft(3)} characters long: {currentString}")
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox("This File you are looking for does not exist...")
        End Try
    End Sub
End Module
