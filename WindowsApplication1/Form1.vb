Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.MyServices
Public Module GlobalVariables
	Public s_FilterCountAll As Integer = 0
	Public s_FilterCountCurrent As Integer = 0
	Public s_FiltrStacjiMin As Integer = 0
	Public s_FiltrStacjiMax As Integer = 20000
End Module
Public Class Form1
    Private Const skNazwaRaportu As String = "\Raport.pdf"

    Private Sub AddNewColumn(ByRef table As DataTable, columnType As String, columnName As String)
        Dim dataColumn As DataColumn = table.Columns.Add(columnName, Type.[GetType](columnType))
    End Sub
    Private Sub AddNewRow(ByRef table As DataTable, ByRef fid As String, ByRef fsta As String, ByRef fist As String, ByRef fver As String, ByRef fstat As String)
        Dim bool_ As Boolean = True 'Operators.CompareString(fsta.Substring(2, 3), TextBoxStacja.Text, False) = 0 Or Operators.CompareString(TextBoxStacja.Text, "", False) = 0
        If bool_ Then
            Dim dataRow As DataRow = table.NewRow()
            dataRow("sAreaID") = fid
            dataRow("sFixtureST") = fsta
            dataRow("sFixtureName") = fist
            dataRow("sFixtureVer") = fver
            dataRow("sFrgStat") = fstat
            table.Rows.Add(dataRow)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If True Then 'wtf xd
            Dim dataSet As New DataSet()
            Dim table As New DataTable("Student")
            AddNewColumn(table, "System.String", "sAreaID")
            AddNewColumn(table, "System.String", "sFixtureST")
            AddNewColumn(table, "System.String", "sFixtureName")
            AddNewColumn(table, "System.String", "sFixtureVer")
            AddNewColumn(table, "System.String", "sFrgStat")
            ProgressBar1.Value = 20
            labelFRGCounter.Text = 0
            labelPPTCounter.Text = 0
            labelEmailCounter.Text = 0
            labelInsimCounter.Text = 0
            Dim enumerator As IEnumerator(Of String) = Directory.EnumerateDirectories(sSciezka.Text).GetEnumerator()
            While enumerator.MoveNext()
                Dim current As String = enumerator.Current
                Dim bool_ As Boolean = Operators.CompareString(current.Substring(sSciezka.Text.Length + 1, 9), "folderKON", False) = 0
                If bool_ Then
                    Dim AktNazwaLinii As String = current.Substring(sSciezka.Text.Length + 11) ' aktualna nazwa folderu linii, np HC61
                    'Try
                    Dim enumerator2 As IEnumerator(Of String) = Directory.EnumerateDirectories(current).GetEnumerator()
                    While enumerator2.MoveNext()
                        Dim current2 As String = enumerator2.Current
                        Dim bool_2 As Boolean = Operators.CompareString(current2.Substring(current.Length + 1, 2), "ST", False) = 0
                        If bool_2 Then
                            Dim AktNazwaStacji As String = current2.Substring(sSciezka.Text.Length + AktNazwaLinii.Length + 12) 'jeśli folder zaczyna się od ST, nazwa aktualnego folderu stacji
                            Dim arr_ As String() = New String(Directory.EnumerateDirectories(current2).Count - 1) {}
                            Dim int_ As Integer = 0
                            ' Try
                            Dim enumerator3 As IEnumerator(Of String) = Directory.EnumerateDirectories(current2).GetEnumerator()
                            While enumerator3.MoveNext()
                                Dim current3 As String = enumerator3.Current
                                arr_(int_) = current3.Substring(current2.Length + 1)
                                Math.Max(System.Threading.Interlocked.Increment(int_), int_ - 1)
                            End While

                            'End Try
                            Array.Sort(arr_)
                            Dim int_2 As Integer = int_ - 1
                            Dim i As Integer = 0
                            While i <= int_2
                                Dim AktNazwaKonstrukcji As String = arr_(i) 'pokręcona metoda uzyskania aktualnego folderu konstrukcji
                                Dim arr_2 As String() = New String(Directory.EnumerateDirectories(current2 + "\" + arr_(i)).Count - 1) {}
                                Dim int_3 As Integer = 0
                                'Try
                                Dim enumerator4 As IEnumerator(Of String) = Directory.EnumerateDirectories(current2 + "\" + arr_(i)).GetEnumerator()
                                While enumerator4.MoveNext()
                                    Dim current4 As String = enumerator4.Current
                                    arr_2(int_3) = current4.Substring((current2 + "\" + arr_(i)).Length)
                                    Math.Max(System.Threading.Interlocked.Increment(int_3), int_3 - 1)
                                End While
                                'End Try
                                Array.Sort(arr_2)
                                Dim checked As Boolean = CheckBox1.Checked 'tu chyba się sprawdzało, czy ma pokazywać tylko ostatnie loopy konstrukcji
                                If checked Then
                                    Dim bool_3 As Boolean = Directory.EnumerateDirectories(current2 + "\" + arr_(i)).Count > 0
                                    If bool_3 Then
                                        Dim str_4 As String = String.Concat(New String() {current2, "\", arr_(i), "\", arr_2(int_3 - 1)})
                                        Dim AktNazwaLoopKonstrukcji As String = str_4.Substring((current2 + "\" + arr_(i)).Length + 1)
                                        Dim TematMaila As String = ""
                                        Dim NazwaPlikuPrezentacji As String = ""
                                        Dim enumerable As IEnumerable(Of String) = Directory.EnumerateFiles(str_4, "*.*", SearchOption.TopDirectoryOnly)
                                        Dim bool_4 As Boolean = False
                                        Dim bool_5 As Boolean = False
                                        Dim bool_6 As Boolean = False
                                        'Try
                                        Dim enumerator5 As IEnumerator(Of String) = enumerable.GetEnumerator()
                                        While enumerator5.MoveNext()
                                            Dim current5 As String = enumerator5.Current
                                            'Dim bool_9 As Boolean = current5.Contains("frg.txt")
                                            'new method of searching, I hope it is faster, or at least not slower
                                            Dim bool_9 As Boolean = Regex.IsMatch(current5, "frg\.\w{3,4}$")
                                            If bool_9 Then
                                                bool_6 = True
                                            End If
                                            'Dim bool_7 As Boolean = current5.Contains(".pptx") OrElse current5.Contains(".ppt")
                                            Dim bool_7 As Boolean = Regex.IsMatch(current5, "pptx?$")
                                            If bool_7 Then
                                                bool_4 = True
                                                NazwaPlikuPrezentacji = current5.Substring(str_4.Length + 1)
                                            End If
                                            'Dim bool_8 As Boolean = current5.Contains(".eml") OrElse current5.Contains(".msg")
                                            Dim bool_8 As Boolean = Regex.IsMatch(current5, "eml$|msg$")
                                            If bool_8 Then
                                                bool_5 = True
                                                TematMaila = current5.Substring(str_4.Length + 1)
                                            End If

                                        End While
                                        'End Try
                                        Dim AktStatusKonstrukcji As String = "in SIM"
                                        Dim bool_10 As Boolean = bool_6
                                        If bool_10 AndAlso bool_5 Then
                                            AktStatusKonstrukcji = "Free for detailing"
                                            labelFRGCounter.Text = labelFRGCounter.Text + 1
                                        Else
                                            Dim bool_11 As Boolean = bool_5
                                            If bool_11 Then
                                                AktStatusKonstrukcji = "EML/MSG (" + TematMaila + ")"
                                                labelEmailCounter.Text = labelEmailCounter.Text + 1
                                            Else
                                                Dim bool_12 As Boolean = bool_4
                                                If bool_12 Then
                                                    AktStatusKonstrukcji = "PPT (" + NazwaPlikuPrezentacji + ")"
                                                    labelPPTCounter.Text = labelPPTCounter.Text + 1
                                                End If
                                            End If
                                        End If
                                        AddNewRow(table, AktNazwaLinii, AktNazwaStacji, AktNazwaKonstrukcji, AktNazwaLoopKonstrukcji, AktStatusKonstrukcji)
                                    End If
                                Else 'a tu warunek, jeśli miałby jednak pokazać wszystkie loopy konstrukcji
                                    Dim int_4 As Integer = int_3 - 1
                                    Dim j As Integer = 0
                                    While j <= int_4
                                        Dim str_7 As String = String.Concat(New String() {current2, "\", arr_(i), "\", arr_2(j)})
                                        Dim str_5 As String = str_7.Substring((current2 + "\" + arr_(i)).Length + 1)
                                        Dim str As String = ""
                                        Dim str2 As String = ""
                                        Dim enumerable2 As IEnumerable(Of String) = Directory.EnumerateFiles(str_7, "*.*", SearchOption.TopDirectoryOnly)
                                        Dim bool_4 As Boolean = False
                                        Dim bool_5 As Boolean = False
                                        Dim bool_6 As Boolean = False
                                        'Try
                                        Dim enumerator6 As IEnumerator(Of String) = enumerable2.GetEnumerator()
                                        While enumerator6.MoveNext()
                                            Dim current6 As String = enumerator6.Current
                                            Dim bool_13 As Boolean = current6.Contains(".pptx") OrElse current6.Contains(".ppt")
                                            If bool_13 Then
                                                bool_4 = True
                                                str2 = current6.Substring(str_7.Length + 1)
                                            End If
                                            Dim bool_14 As Boolean = current6.Contains(".eml") OrElse current6.Contains(".msg")
                                            If bool_14 Then
                                                bool_5 = True
                                                str = current6.Substring(str_7.Length + 1)
                                            End If
                                            Dim bool_15 As Boolean = current6.Contains("frg.")
                                            If bool_15 Then
                                                bool_6 = True
                                            End If
                                        End While
                                        'End Try
                                        Dim str_6 As String = "in SIM"
                                        Dim bool_16 As Boolean = bool_6
                                        If bool_16 AndAlso bool_5 Then
                                            str_6 = "Free for detailing"
                                        Else
                                            Dim bool_17 As Boolean = bool_5
                                            If bool_17 Then
                                                str_6 = "EML/MSG (" + str + ")"
                                            Else
                                                Dim bool_18 As Boolean = bool_4
                                                If bool_18 Then
                                                    str_6 = "PPT (" + str2 + ")"
                                                End If
                                            End If
                                        End If
                                        AddNewRow(table, AktNazwaLinii, AktNazwaStacji, AktNazwaKonstrukcji, str_5, str_6)
                                        Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
                                    End While
                                End If
                                Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                            End While
                        End If
                    End While
                    'End Try
                End If
            End While
            'End Try
            dataSet.Tables.Add(table)
            DataGridView1.DataSource = dataSet.Tables("Student")
            DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Ascending)
            Me.DataGridView1.CurrentCell = Nothing
            s_FilterCountAll = DataGridView1.RowCount
            s_FilterLabel.Text = s_FilterCountAll & " / " & s_FilterCountAll
            labelInsimCounter.Text = s_FilterCountAll - labelEmailCounter.Text - labelFRGCounter.Text - labelPPTCounter.Text
            Dim now2 As DateTime = DateAndTime.Now
            Dim varOFO0 As Label = Label3
            Dim timeSpan As TimeSpan = now2.Subtract(DateAndTime.Now)
            Dim totalSeconds As Double = timeSpan.TotalSeconds
            varOFO0.Text = totalSeconds.ToString("0.00") + "s"
            ProgressBar1.Value = 100
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileSystem As FileSystemProxy = My.Computer.FileSystem
        sSciezka.Text = fileSystem.CurrentDirectory
        '***** USTAWIENIA *****
        Dim NazwaProjektu As String = "uniwersalne XNNx_YYMMDD" 'wpisz nazwe projektu
        Dim DomyslnieTylkoOstatnieWersje As Boolean = True 'czy po włączeniu programu ma domyślnie pokazać tylko najnowsze loopy kontrukcji
        errorMessageStationFilter.Text = "Numery stacji są OK"
        errorMessageStationFilter.ForeColor = Color.DarkGreen
        '***** USTAWIENIA KONIEC *****
        '***** USTAWIENIA MYSETTINGS LADUJ *****
        TextBoxStacja.Text = My.Settings.stNumeryStacji
        s_FiltrStacjiAktywny.Checked = My.Settings.stFiltrStacjiAktywny
        '***** USTAWIENIA MYSETTINGS LADUJ KONIEC *****
        CheckBox1.Checked = DomyslnieTylkoOstatnieWersje

        Me.Text = "SK2017-2019 | 20191031 2.72 | " + NazwaProjektu
        Button1.PerformClick()
        buttonEksportDoCsv.PerformClick()
    End Sub

    ' zapisuje ustawienia uzytkownika przy wyjsciu z aplikacji:
    Private Sub Form1_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        My.Settings.stNumeryStacji = TextBoxStacja.Text
        My.Settings.stFiltrStacjiAktywny = s_FiltrStacjiAktywny.Checked
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim bool_ As Boolean = e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0
        If bool_ Then
            Dim dataGridViewRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() {Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sSciezka.Text + "\folderKON_", dataGridViewRow.Cells(0).Value), "\"), dataGridViewRow.Cells(1).Value), "\"), dataGridViewRow.Cells(2).Value), "\"), dataGridViewRow.Cells(3).Value)}, Nothing, Nothing, Nothing, True)
        End If
    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim dgvRow As DataGridViewRow = Me.DataGridView1.Rows(e.RowIndex)
        'jesli zaznaczone jest ukrywanie frg, to nie rysuj takich wierszy:
        If dgvRow.Cells("sFrgStat").Value = "Free for detailing" And s_UkryjFreeForDetailing2.Checked Then
            dgvRow.Visible = False
            Exit Sub
        End If
        'jesli ustawiony jest filtr na stacje, nie rysuj wierszy z poza filtra:
        'Dim sCurrentRowStNr As Integer = Convert.ToDecimal(Mid(dgvRow.Cells("sFixtureST").Value, 3))
        Dim sCurrentRowStNr As Integer
        'new awesome method of checking station number, if station number does not match the structure it will not result in error, only will not be listed in filtered view.
        If Not Int32.TryParse(Mid(dgvRow.Cells("sFixtureST").Value, 3), sCurrentRowStNr) Then
            errorMessageStationFilter.Text = "Występują stacje niepoprawnie nazwane!"
            errorMessageStationFilter.ForeColor = Color.OrangeRed
        End If
        'sCurrentRowStNr = Int32.Parse(Mid(dgvRow.Cells("sFixtureST").Value, 3))
        If (sCurrentRowStNr < s_FiltrStacjiMin Or sCurrentRowStNr > s_FiltrStacjiMax) And s_FiltrStacjiAktywny.Checked Then
            dgvRow.Visible = False
            Exit Sub
        End If
        'row coloring start:
        If dgvRow.Cells("sFrgStat").Value = "Free for detailing" AndAlso LCase(dgvRow.Cells("sFixtureVer").Value).Contains("_kin") Then
            dgvRow.DefaultCellStyle.BackColor = Color.LightBlue
        ElseIf dgvRow.Cells("sFrgStat").Value = "Free for detailing" Then
            dgvRow.DefaultCellStyle.BackColor = Color.LightGreen
        ElseIf dgvRow.Cells("sFrgStat").Value = "in SIM" Or dgvRow.Cells("sFrgStat").Value.Contains("PPT ") Then
            dgvRow.DefaultCellStyle.BackColor = Color.Gold
        End If
    End Sub

    Private Sub s_UkryjFreeForDetailing2_CheckedChanged(sender As Object, e As EventArgs) Handles s_UkryjFreeForDetailing2.CheckedChanged
        Me.DataGridView1.CurrentCell = Nothing
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Visible = False Then
                DataGridView1.Rows.Item(row.Index).Visible = True
            End If
        Next
        DataGridView1.Refresh()
    End Sub

    Private Sub s_FiltrStacjiAktywny_CheckedChanged(sender As Object, e As EventArgs) Handles s_FiltrStacjiAktywny.CheckedChanged, TextBoxStacja.TextChanged
        Me.DataGridView1.CurrentCell = Nothing
        Dim getnums As Array
        Dim RegExpObj As Object
        Dim NumStr As String
        RegExpObj = CreateObject("vbscript.regexp")
        With RegExpObj
            .Global = True
            .Pattern = "[^\d]+"
            NumStr = .Replace(TextBoxStacja.Text, " ")
        End With
        getnums = Split(Trim(NumStr), " ")
        If getnums(0) = "" Then
            s_FiltrStacjiMin = 0
            s_FiltrStacjiMax = 20000
        ElseIf getnums.Length = 1 Or getnums.Length = 2 Then
            s_FiltrStacjiMin = Convert.ToDecimal(getnums(0)) - 9
            s_FiltrStacjiMax = Convert.ToDecimal(getnums(getnums.Length - 1)) + 9
        End If
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Visible = False Then
                DataGridView1.Rows.Item(row.Index).Visible = True
            End If
        Next
        DataGridView1.Refresh()
    End Sub

    Private Sub buttonEksportDoCsv_Click(sender As Object, e As EventArgs) Handles buttonEksportDoCsv.Click
        'This way increases performance without casting
        Dim filePath As String = "StatusEksport.csv"
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim array As String() = New String(DataGridView1.Columns.Count - 1) {}
            If i.Equals(0) Then
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    array(j) = DataGridView1.Columns(j).HeaderText
                Next
                sb.AppendLine(String.Join(delimeter, array))
            End If
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If Not DataGridView1.Rows(i).IsNewRow Then
                    array(j) = DataGridView1(j, i).Value.ToString
                End If
            Next
            If Not DataGridView1.Rows(i).IsNewRow Then
                sb.AppendLine(String.Join(delimeter, array))
            End If
        Next
        File.WriteAllText(filePath, sb.ToString)
        'Process.Start(filePath)	'Opens the file immediately after writing; not needed generally, only for debugging.
        My.Computer.FileSystem.WriteAllText((sSciezka.Text & filePath), sb.ToString, False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bGenerujRaportPDF.Click
        ProgressBar2.Value = 20
        Label5.Text = "czekaj"
        Dim mypath As String = sSciezka.Text
        Dim XLApp As Object
        Dim wr As Object
        XLApp = CreateObject("Excel.Application")
        XLApp.visible = False   ' not required, you do not need to see this happening
        XLApp.DisplayAlerts = False 'IT WORKS TO DISABLE ALERT PROMPT
        Dim fname As String = "\konfiguracjaRaportu.xlsx"
        Try
            wr = XLApp.workbooks.Open(mypath & fname)
            wr.refreshall()
            'Application.Wait(Now + TimeValue("0:00:05"))
            System.Threading.Thread.Sleep(1000)
            wr.WorkSheets.Select()
            Try
                wr.ActiveSheet.ExportAsFixedFormat(0, mypath & skNazwaRaportu)
            Catch errorReadOnly As Exception
                Dim msg = MsgBox("Błąd, nie zapisanego nowego raportu. Sprawdz czy plik nie jest już otwarty i spróbuj jeszcze raz." & vbNewLine & "Kod błędu:" & vbNewLine & errorReadOnly.Message)
            End Try
            wr.WorkSheets(1).Select()
            wr.Save
            wr.Close
            XLApp.Quit
            Process.Start(mypath & skNazwaRaportu)
            'wr = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(XLApp)
            XLApp = Nothing
            ProgressBar2.Value = 100
            Label5.Text = "koniec"
        Catch ex As Exception
            Dim msg = MsgBox("Błąd, nie znaleziono pliku konfiguracji Power Pivot. Skontaktuj sie z administartorem projektu." & vbNewLine & "Kod błędu:" & vbNewLine & ex.Message)
        Finally
            'wr = Nothing
            If Not XLApp = Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(XLApp)
            End If
            XLApp = Nothing
            ProgressBar2.Value = 100
            Label5.Text = "koniec"
        End Try

    End Sub
End Class