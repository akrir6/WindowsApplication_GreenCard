Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The example assumes your form has a Button control, 
        ' a PrintDocument component named myDocument, 
        ' and a PrintPreviewDialog control. 


        ' Handle the PrintPage event to write the print logic.
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage


        ' Specify a PrintDocument instance for the PrintPreviewDialog component.
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1

        DateTimePicker3.Value = Now
        DateTimePicker4.Value = Now
        DateTimePicker1.Value = DateTimePicker3.Value.AddDays(1)
        ComboBox1.Text = ComboBox1.Items(0)
        ComboBox2.Text = ComboBox2.Items(0)
        ComboBox3.Text = ComboBox3.Items(0)
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        ' Specify what to print and how to print in this event handler.
        ' The follow code specify a string and a rectangle to be print 


        Dim f As Font = New Font("Arial", 14, FontStyle.Bold)
        Dim fm As Font = New Font("Arial", 12, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black)
        Dim dm1, dm2, dd1, dd2 As String
        dm1 = ""
        dm2 = ""
        dd1 = ""
        dd2 = ""
        'e.Graphics.DrawString("This is a text.", f, br, 50, 50)
        'e.Graphics.DrawRectangle(p, 10, 10, 800, 1150)
        'e.Graphics.DrawString(Now(), f, br, 100, 100)
        '----------1----------
        If Int(DateTimePicker1.Value.Month) < 10 Then dm1 = "0"

        If Int(DateTimePicker2.Value.Month) < 10 Then dm2 = "0"

        If Int(DateTimePicker1.Value.Day) < 10 Then dd1 = "0"

        If Int(DateTimePicker2.Value.Day) < 10 Then dd2 = "0"

        e.Graphics.DrawString(dd1 + Str(DateTimePicker1.Value.Day), f, br, 130, 80)
        e.Graphics.DrawString(dm1 + Str(DateTimePicker1.Value.Month), f, br, 190, 80)
        e.Graphics.DrawString(DateTimePicker1.Value.Year, f, br, 240, 80)

        e.Graphics.DrawString(dd2 + Str(DateTimePicker2.Value.Day), f, br, 360, 80)
        e.Graphics.DrawString(dm2 + Str(DateTimePicker2.Value.Month), f, br, 420, 80)
        e.Graphics.DrawString(DateTimePicker2.Value.Year, f, br, 480, 80)

        e.Graphics.DrawString(TextBox3.Text, f, br, 400, 120)
        e.Graphics.DrawString(ComboBox3.Text, f, br, 740, 120)

        e.Graphics.DrawString(TextBox2.Text, fm, br, 10, 175)
        e.Graphics.DrawString(TextBox4.Text, fm, br, 10, 190)

        e.Graphics.DrawString(TextBox1.Text, fm, br, 330, 310)
        e.Graphics.DrawString(TextBox5.Text, fm, br, 330, 330)
        '----------2----------
        e.Graphics.DrawString(dd1 + Str(DateTimePicker1.Value.Day), f, br, 170, 480)
        e.Graphics.DrawString(dm1 + Str(DateTimePicker1.Value.Month), f, br, 210, 480)
        e.Graphics.DrawString(DateTimePicker1.Value.Year, f, br, 260, 480)

        e.Graphics.DrawString(dd2 + Str(DateTimePicker2.Value.Day), f, br, 350, 480)
        e.Graphics.DrawString(dm2 + Str(DateTimePicker2.Value.Month), f, br, 400, 480)
        e.Graphics.DrawString(DateTimePicker2.Value.Year, f, br, 440, 480)

        e.Graphics.DrawString(TextBox3.Text, f, br, 200, 510)
        e.Graphics.DrawString(ComboBox3.Text, f, br, 480, 510)

        e.Graphics.DrawString(TextBox2.Text, fm, br, 620, 505)
        e.Graphics.DrawString(TextBox4.Text, fm, br, 620, 520)

        e.Graphics.DrawString(TextBox1.Text, fm, br, 220, 635)
        e.Graphics.DrawString(TextBox5.Text, fm, br, 220, 655)

        e.Graphics.DrawString(Label_TS.Text, fm, br, 130, 690)
        e.Graphics.DrawString(DateTimePicker3.Value, fm, br, 230, 690)
        e.Graphics.DrawString(TextBox6.Text, fm, br, 600, 700)

        '----------3----------
        e.Graphics.DrawString(dd1 + Str(DateTimePicker1.Value.Day), f, br, 170, 830)
        e.Graphics.DrawString(dm1 + Str(DateTimePicker1.Value.Month), f, br, 210, 830)
        e.Graphics.DrawString(DateTimePicker1.Value.Year, f, br, 260, 830)

        e.Graphics.DrawString(dd2 + Str(DateTimePicker2.Value.Day), f, br, 350, 830)
        e.Graphics.DrawString(dm2 + Str(DateTimePicker2.Value.Month), f, br, 400, 830)
        e.Graphics.DrawString(DateTimePicker2.Value.Year, f, br, 440, 830)

        e.Graphics.DrawString(TextBox3.Text, f, br, 200, 870)
        e.Graphics.DrawString(ComboBox3.Text, f, br, 480, 870)

        e.Graphics.DrawString(TextBox2.Text, fm, br, 620, 860)
        e.Graphics.DrawString(TextBox4.Text, fm, br, 620, 875)

        e.Graphics.DrawString(TextBox1.Text, fm, br, 220, 990)
        e.Graphics.DrawString(TextBox5.Text, fm, br, 220, 1010)

        e.Graphics.DrawString(Label_TS.Text, fm, br, 130, 1040)
        e.Graphics.DrawString(DateTimePicker3.Value, fm, br, 230, 1040)
        e.Graphics.DrawString(TextBox6.Text, fm, br, 600, 1050)


    End Sub


    'Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
    '    Me.PrintPreviewDialog1.ShowDialog()
    'End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                DateTimePicker2.Value = DateTimePicker1.Value.AddDays(14)
            Case 12
                DateTimePicker2.Value = DateTimePicker1.Value.AddYears(1).AddDays(-1)
            Case 1 To 11
                DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(ComboBox1.SelectedIndex).AddDays(-1)
        End Select
        calcZK()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Call ComboBox1_SelectedIndexChanged(ComboBox1, e)
    End Sub

  
    'Private WithEvents docToPrint As New Printing.PrintDocument

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        PrintDialog1.AllowSomePages = False

        ' Show the help button.
        PrintDialog1.ShowHelp = False

        ' Set the Document property to the PrintDocument for 
        ' which the PrintPage Event has been handled. To display the
        ' dialog, either this property or the PrinterSettings property 
        ' must be set 
        PrintDialog1.Document = PrintDocument1

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PageSetupDialog1.PageSettings = _
      New System.Drawing.Printing.PageSettings

        ' Initialize dialog's PrinterSettings property to hold user
        ' set printer settings.
        PageSetupDialog1.PrinterSettings = _
            New System.Drawing.Printing.PrinterSettings

        'Do not show the network in the printer dialog.
        PageSetupDialog1.ShowNetwork = False

        'Show the dialog storing the result.
        Dim result As DialogResult = PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

  
   
  
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        calcZK()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        calcZK()
    End Sub

    Private Sub calcZK()
        Select Case ComboBox2.SelectedIndex
            Case 0
                Select Case ComboBox3.SelectedIndex
                    Case 0
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(788, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(1255, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(2169, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(2981, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(3773, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(4735, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(5572, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(6409, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(6564, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(6735, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(6776, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(6838, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(6899, 2)
                        End Select
                    Case 1
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(315, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(434, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(724, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(1014, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(1307, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(1593, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(1886, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(2173, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(2466, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(2627, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(2742, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(2807, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(2920, 2)
                        End Select
                    Case 2
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(1860, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(2468, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(4444, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(6255, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(8065, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(9876, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(11687, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(13497, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(15308, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(17118, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(18765, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(20411, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(22057, 2)
                        End Select
                    Case 3
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(2962, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(4115, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(6172, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(8230, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(10288, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(12345, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(14403, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(16460, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(18518, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(20575, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(22633, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(24691, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(26748, 2)
                        End Select
                    Case 4
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(272, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(378, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(650, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(923, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(1196, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(1468, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(1741, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(2013, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(2286, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(2558, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(2830, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(3103, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(1893, 2)
                        End Select
                End Select
            Case 1
                Select Case ComboBox3.SelectedIndex
                    Case 0
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(574, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(845, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(1149, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(1419, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(1690, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(1859, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(1937, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(2068, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(2200, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(2331, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(2495, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(2627, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(2758, 2)
                        End Select
                    Case 1
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(67, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(135, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(270, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(371, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(439, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(540, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(591, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(623, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(656, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(689, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(722, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(755, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(788, 2)
                        End Select
                    Case 2
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(304, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(608, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(1081, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(1554, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(1926, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(2231, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(2430, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(2627, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(2824, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(2955, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(3086, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(3218, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(3316, 2)
                        End Select
                    Case 3
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(608, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(1216, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(2163, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(3076, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(3819, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(4428, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(4827, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(5221, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(5615, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(5878, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(6140, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(6403, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(6600, 2)
                        End Select
                    Case 4
                        Select Case ComboBox1.SelectedIndex
                            Case 0
                                Label_TS.Text = FormatNumber(131, 2)
                            Case 1
                                Label_TS.Text = FormatNumber(200, 2)
                            Case 2
                                Label_TS.Text = FormatNumber(331, 2)
                            Case 3
                                Label_TS.Text = FormatNumber(463, 2)
                            Case 4
                                Label_TS.Text = FormatNumber(600, 2)
                            Case 5
                                Label_TS.Text = FormatNumber(732, 2)
                            Case 6
                                Label_TS.Text = FormatNumber(844, 2)
                            Case 7
                                Label_TS.Text = FormatNumber(844, 2)
                            Case 8
                                Label_TS.Text = FormatNumber(872, 2)
                            Case 9
                                Label_TS.Text = FormatNumber(872, 2)
                            Case 10
                                Label_TS.Text = FormatNumber(905, 2)
                            Case 11
                                Label_TS.Text = FormatNumber(905, 2)
                            Case 12
                                Label_TS.Text = FormatNumber(939, 2)
                        End Select
                    
                End Select
        End Select
        Label_TS.Text = FormatNumber(Label_TS.Text, 2)
    End Sub


End Class
