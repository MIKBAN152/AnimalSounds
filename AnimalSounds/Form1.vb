Imports System.Xml
Imports System.Data
Imports System.Xml.Schema
Imports System.Text
Imports System.Xml.XmlReader
Imports System.IO
Public Class Form1

    Dim soundPath As String = ""
    Dim startgame As Boolean = False
    Dim serial_port As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        If startgame Then
            startgame = False
            btn_play.Text = "MANUAL"
            pnl_sounds.Visible = False
            thegame()
        Else
            startgame = True
            btn_play.Text = "AUTO"
            pnl_sounds.Visible = True
            'thegame()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        soundPath = System.Windows.Forms.Application.StartupPath & "\sonidos\"
        Dim file_name As String = System.Windows.Forms.Application.StartupPath & "\floor_cfg.xml"
        Dim doc As New XmlDocument()

        Try
            'Se carga el documento xml
            doc.Load(file_name)

            'Dim xmllist As XmlNodeList = doc.SelectNodes("config").Item(0).ChildNodes
            Dim xmlserialport As String = doc.SelectNodes("config").Item(0).ChildNodes.Item(0).InnerText.ToString
            serial_port = xmlserialport
        Catch ex As Exception
            MsgBox("Cannot setup Serial Port")
        End Try

    End Sub



    Private Sub playSound(ByVal nmr_son As Integer)

        Select Case nmr_son
            Case 1
                My.Computer.Audio.Play(soundPath & "sonido1.wav")
            Case 2
                My.Computer.Audio.Play(soundPath & "sonido2.wav")
            Case 3
                My.Computer.Audio.Play(soundPath & "sonido3.wav")
            Case 4
                My.Computer.Audio.Play(soundPath & "sonido4.wav")
            Case 5
                My.Computer.Audio.Play(soundPath & "sonido5.wav")
            Case 6
                My.Computer.Audio.Play(soundPath & "sonido6.wav")
            Case Else
                'My.Computer.Audio.Play(soundPath & "Alarm01.wav")
        End Select

    End Sub

    Private Sub btn_s1_Click(sender As Object, e As EventArgs) Handles btn_s1.Click
        If startgame Then
            playSound(1)
        End If
    End Sub

    Private Sub btn_s2_Click(sender As Object, e As EventArgs) Handles btn_s2.Click
        If startgame Then
            playSound(2)
        End If
    End Sub

    Private Sub btn_s3_Click(sender As Object, e As EventArgs) Handles btn_s3.Click
        If startgame Then
            playSound(3)
        End If
    End Sub

    Private Sub btn_s4_Click(sender As Object, e As EventArgs) Handles btn_s4.Click
        If startgame Then
            playSound(4)
        End If
    End Sub

    Private Sub btn_s5_Click(sender As Object, e As EventArgs) Handles btn_s5.Click
        If startgame Then
            playSound(5)
        End If
    End Sub

    Private Sub btn_s6_Click(sender As Object, e As EventArgs) Handles btn_s6.Click
        If startgame Then
            playSound(6)
        End If
    End Sub

    Private Sub thegame()

        While (Not startgame)
            Application.DoEvents()
            My.Application.Log.WriteEntry("cycle")
            Dim opt As Integer = 0
                Dim Data As String = ""
                Dim Data_clean As String = ""
            Try
                Me.SerialPort1.Close()
                Me.SerialPort1.PortName = serial_port '"COM3"
                Me.SerialPort1.BaudRate = 9600
                Me.SerialPort1.Parity = System.IO.Ports.Parity.None
                Me.SerialPort1.DataBits = 8
                SerialPort1.StopBits = System.IO.Ports.StopBits.One
                'SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 3000
                Me.SerialPort1.Open()
                'Me.SerialPort1.WriteLine("R:")

                'Threading.Thread.Sleep(100)

                Try
                    Data = Me.SerialPort1.ReadTo("?")
                    My.Application.Log.WriteEntry(Data)
                    opt = CInt(Data)
                    playSound(opt)
                Catch ex As Exception
                    My.Application.Log.WriteEntry("no message")
                    'Exit While
                End Try

                Me.SerialPort1.Close()

            Catch ex As Exception
                My.Application.Log.WriteEntry("setting up error")
                'Exit While
            End Try
            Threading.Thread.Sleep(200)
        End While
    End Sub

End Class