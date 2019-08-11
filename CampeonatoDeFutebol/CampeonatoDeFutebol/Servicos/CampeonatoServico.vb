Imports System.Text.RegularExpressions

Public Class CampeonatoServico
    Sub IniciarProcessamentoCampeonato(ByVal vetpartidas() As String)
        Try
            'criando um laco para percorrrer as informacoes entre as virgulas da string de entrada
            For i As Integer = 0 To vetpartidas.Count - 1
                SeparaInformacoesPartida(vetpartidas(i))
            Next i
        Catch ex As Exception

        End Try
    End Sub
    Sub CalcularResultadoPartida(ByVal partida As PartidasModelo)
        Try
            For i As Integer = 0 To Principal.campeonato.CTimes.Count - 1
                If partida.CTime1.SNome = Principal.campeonato.CTimes(i).SNome Then
                    'determinando a vitoria do time 1
                    If partida.IQtdGolsTime1 > partida.IQtdGolsTime2 Then
                        Principal.campeonato.CTimes(i).IPontuacao += 3
                        Principal.campeonato.CTimes(i).IQtdVitorias += 1
                        'determinando o empate do time 1
                    ElseIf partida.IQtdGolsTime1 = partida.IQtdGolsTime2 Then
                        Principal.campeonato.CTimes(i).IPontuacao += 1
                        Principal.campeonato.CTimes(i).IQtdEmpates += 1
                        'determinando a derrota do time 1
                    Else
                        Principal.campeonato.CTimes(i).IPontuacao += 0
                        Principal.campeonato.CTimes(i).IQtdDerrotas += 1
                    End If
                    'capturando os gols 
                    Principal.campeonato.CTimes(i).IQtdGolsFeitos_1 += partida.IQtdGolsTime1
                    Principal.campeonato.CTimes(i).IQtdGolsTomados += partida.IQtdGolsTime2
                    'verificando se o time 2 é igual ao indice atual
                ElseIf partida.CTime2.SNome = Principal.campeonato.CTimes(i).SNome Then
                    'determinando a vitoria do time 1
                    If partida.IQtdGolsTime2 > partida.IQtdGolsTime1 Then
                        Principal.campeonato.CTimes(i).IPontuacao += 3
                        Principal.campeonato.CTimes(i).IQtdVitorias += 1
                        'determinando o empate do time 1
                    ElseIf partida.IQtdGolsTime2 = partida.IQtdGolsTime1 Then
                        Principal.campeonato.CTimes(i).IPontuacao += 1
                        Principal.campeonato.CTimes(i).IQtdEmpates += 1
                        'determinando a derrota do time 1
                    Else
                        Principal.campeonato.CTimes(i).IPontuacao += 0
                        Principal.campeonato.CTimes(i).IQtdDerrotas += 1
                    End If
                    'capturando os gols 
                    Principal.campeonato.CTimes(i).IQtdGolsFeitos_1 += partida.IQtdGolsTime2
                    Principal.campeonato.CTimes(i).IQtdGolsTomados += partida.IQtdGolsTime1
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub SeparaInformacoesPartida(ByRef info As String)
        Try
            Dim partida As New PartidasModelo
            'Separa as informacoes do time 1 e do time 2
            Dim vetInfo(4) As String
            'separando todas as informacoes da string da partida
            vetInfo = info.Split(" ")
            ' 0 = nome time 1
            ' 1 = placar time 1
            ' 2 = nome time 2
            ' 3 = placar time 2
            partida.CTime1 = New TimesModelo
            partida.CTime2 = New TimesModelo

            partida.CTime1.SNome = vetInfo(0)
            partida.IQtdGolsTime1 = Int32.Parse(vetInfo(1))
            partida.CTime2.SNome = vetInfo(2)
            partida.IQtdGolsTime2 = Int32.Parse(vetInfo(3))
            CalcularResultadoPartida(partida)
        Catch ex As Exception

        End Try
    End Sub
    Sub OrdenarLista()
        Try
            'ordenando pela pontuacao
            campeonato.CTimes = campeonato.CTimes.OrderBy(Function(x) x.IPontuacao).ToList()
            'ordenando pelo saldo de gols
            campeonato.CTimes = campeonato.CTimes.OrderBy(Function(x) x.IQtdGolsFeitos_1 - x.IQtdGolsTomados).ToList()
        Catch ex As Exception

        End Try
    End Sub
    Sub InicializarTimes(ByVal s As String)
        Try
            'removendo os numeros e as virgulas da string de entrada para capturar os times apenas
            Dim pattern As String = "[^a-zA-Z\s]"
            Dim replacement As String = ""
            Dim rgx As Regex = New Regex(pattern)
            Dim result As String = rgx.Replace(s, replacement)
            Dim StrArray() As String = result.Split(" ")

            Dim meuHashSet = New HashSet(Of String)

            'permitindo apenas os nomes unicos utilizando o hashset
            For Each snome As String In StrArray
                If snome <> "" Then
                    meuHashSet.Add(snome)
                End If
            Next

            Principal.campeonato.CTimes = New List(Of TimesModelo)

            'jogando os nomes na lista de times
            For Each snome As String In meuHashSet
                If snome <> "" Then
                    Dim time As New TimesModelo
                    time.SNome = snome
                    Principal.campeonato.CTimes.Add(time)
                End If
            Next

        Catch ex As Exception
        End Try
    End Sub
    Sub AplicarPosicao()
        Try
            'definindo a posicao de cada time dentro lista
            Dim pos As Integer = 1
            For i As Integer = Principal.campeonato.CTimes.Count - 1 To 0 Step -1
                Principal.campeonato.CTimes(i).IColocacao = pos
                pos += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub FormatarExibicaoDados()
        Try
            For i As Integer = Principal.campeonato.CTimes.Count - 1 To 0 Step -1
                Dim texto As String = ""
                texto += Principal.campeonato.CTimes(i).IColocacao.ToString() + " "
                texto += Principal.campeonato.CTimes(i).SNome + " "
                texto += Principal.campeonato.CTimes(i).IPontuacao.ToString() + " "
                texto += Principal.campeonato.CTimes(i).IQtdVitorias.ToString() + " "
                texto += Principal.campeonato.CTimes(i).IQtdEmpates.ToString() + " "
                texto += Principal.campeonato.CTimes(i).IQtdDerrotas.ToString() + " "
                texto += (Principal.campeonato.CTimes(i).IQtdGolsFeitos_1 - Principal.campeonato.CTimes(i).IQtdGolsTomados).ToString() + " "
                Console.WriteLine(texto)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
