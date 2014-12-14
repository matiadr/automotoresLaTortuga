Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word
Public Class formVentas


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    

    Private Sub BuscarCliente(id As String)
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        miConexion.Open()
        Dim seleccion As String = "select NombreC,Domicilio,NombreLocalidad,CodigoPostal,TipoDni,NumeroDni,Telefono, NombreProvincia from Clientes c,Localidades l, Provincias p where l.idprovincia = p.idprovincia and c.IdLocalidad=l.IdLocalidad and IdCliente='" & tbIdCliente.Text & "'"
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        tbNombre.Text = tabla2.Rows.Item(0).Item("NombreC")
        tbDomicilio.Text = tabla2.Rows.Item(0).Item("Domicilio")
        tbLocalidad.Text = tabla2.Rows.Item(0).Item("NombreLocalidad")
        tbCodPostal.Text = tabla2.Rows.Item(0).Item("CodigoPostal")
        tbTipoDoc.Text = tabla2.Rows.Item(0).Item("TipoDni")
        tbNroDoc.Text = tabla2.Rows.Item(0).Item("NumeroDni")
        tbTelefono.Text = tabla2.Rows.Item(0).Item("Telefono")
        textprovincia.Text = tabla2.Rows.Item(0).Item("NombreProvincia")
    End Sub
    Private Sub tbIdCliente_TextChanged(sender As Object, e As EventArgs) Handles tbIdCliente.TextChanged
        If tbIdCliente.Text.Length > 0 Then
            BuscarCliente(tbIdCliente.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bVehVenta.Click
        formBuscarVehiculo.Show()
        formBuscarVehiculo.texttipoboton.Text = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        formBuscarVehiculo.Show()
        formBuscarVehiculo.texttipoboton.Text = 2
    End Sub

    Private Sub tbIdVehVenta_TextChanged(sender As Object, e As EventArgs) Handles tbIdVehVenta.TextChanged
        If tbIdVehVenta.Text.Length > 0 Then
            BuscarAutoVenta(tbIdVehVenta.Text)
        End If
    End Sub


    Private Sub BuscarAutoVenta(id As String)
        Try
            Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
            Dim miConexion As New SqlConnection(CN)
            miConexion.Open()
            Dim seleccion As String = "select IdCliente, NombreMarca,NombreModelo,Tipo,Dominio,Año,TipoMotor,Chasis,Motor,PrecioVenta from Vehiculos v,Marcas ma,Modelos m, vehiculosxclientes vc where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and v.IdVehiculo='" & id & "' and v.idvehiculo = vc.idvehiculo and Estado = 'Activo' "
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)

            If formBuscarVehiculo.texttipoboton.Text = 1 Then
                'escribo en el text el idcliente vendedor del auto que compra el nuevo cliente
                tbidvendedor.Text = tabla2.Rows.Item(0).Item("idcliente")
            Else

            End If
            tbMarcaVehVenta.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            tbModeloVehVenta.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            tbTipoVehVenta.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehVenta.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehVenta.Text = tabla2.Rows.Item(0).Item("Año")
            tbTipoMotorVehVenta.Text = tabla2.Rows.Item(0).Item("TipoMotor")
            tbChasisVehVenta.Text = tabla2.Rows.Item(0).Item("Chasis")
            tbMotorVehVenta.Text = tabla2.Rows.Item(0).Item("Motor")
            tbPrecioVentaVehVenta.Text = tabla2.Rows.Item(0).Item("PrecioVenta")
        Catch ex As SqlException
            MessageBox.Show("No se pudo completar la operacion,Error en la base de datos")
        End Try
    End Sub

    Private Sub BuscarAutoEntrega(id As String)
        Try
            Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
            Dim miConexion As New SqlConnection(CN)
            miConexion.Open()
            Dim seleccion As String = "select NombreMarca,NombreModelo,Tipo,Dominio,Año,TipoMotor,Chasis,Motor,PrecioCosto from Vehiculos v,Marcas ma,Modelos m where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and IdVehiculo='" & id & "'"
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)
            tbMarcaVehVenta.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            tbModeloVehVenta.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            tbTipoVehVenta.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehVenta.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehVenta.Text = tabla2.Rows.Item(0).Item("Año")
            tbTipoMotorVehVenta.Text = tabla2.Rows.Item(0).Item("TipoMotor")
            tbChasisVehVenta.Text = tabla2.Rows.Item(0).Item("Chasis")
            tbMotorVehVenta.Text = tabla2.Rows.Item(0).Item("Motor")
            tbpreciocostoVehVenta.Text = tabla2.Rows.Item(0).Item("PrecioCosto")
        Catch ex As SqlException
            MessageBox.Show("No se pudo completar la operacion,Error en la base de datos")
        End Try
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        If tbIdCliente.Text.Length > 0 Then
            BuscarCliente(tbIdCliente.Text)
        End If
        If tbIdVehVenta.Text.Length > 0 Then
            BuscarAutoVenta(tbIdVehVenta.Text)
        End If
    End Sub



    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click


        formvehiculoentrega.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormEntregasEfectivo.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormDocumentos.Show()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Ventas values ('" & tbidvendedor.Text & "','" & tbIdCliente.Text & "','" & tbIdVehVenta.Text & "','" & TbPrecioCostoVehVenta.Text & "','" & tbPrecioVentaVehVenta.Text & "','" & tbtransferencia.Text & "','" & dtfecha.Value & "',' " & textreal.Text & "')", CN)
        cmd.ExecuteNonQuery()


        'busco el codigo de esta venta...o sea el maximo de la tabla ventas
        Dim venta As New SqlCommand("Select max(idventa) from ventas", CN)
        Dim codigo As String = venta.ExecuteScalar
        textidventa.Text = codigo

        CN.Close()

        'CAMBIO EL ESTADO VENDIDO al VALOR "S", en la tabla vehículos al vehiculo Vendido
        Dim CNV As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CNV.Open()

        Dim cmdv As New SqlCommand("update Vehiculos set Vendido='S' where IdVehiculo = '" & tbIdVehVenta.Text & "'", CNV)
        cmdv.ExecuteNonQuery()


        'CAMBIO EL el campo ESTADO = PASIVO  en la tabla VEHICULOSXCLIENTES al vehiculo Vendido Y CAMBIO LA FECHA HASTA = FECHAVENTA
        Dim cmda As New SqlCommand("update VehiculosxClientes set Estado='Pasivo',FechaHasta= '" & dtfecha.Value & "' where IdVehiculo = '" & tbIdVehVenta.Text & "' and Estado = 'Activo'", CNV)
        cmda.ExecuteNonQuery()



        CNV.Close()




        MessageBox.Show("Venta Ingresada")






            'habilito los groupbox para poder cargar los vehiculos entregados, y otros medios de pagos
            GroupBox3.Enabled = True
        GroupBox4.Enabled = True

        'habilito boton guardar cambios
        Button3.Enabled = True

        'deshabilito paneles de comprador y vehiculo venta
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

        'deshabilito el boton guardar
        Button8.Enabled = False
    End Sub

  

    Private Sub formVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    

    End Sub

    Private Sub tbidvendedor_TextChanged(sender As Object, e As EventArgs) Handles tbidvendedor.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        miConexion.Open()


        Dim seleccion As String = "select NombreC,Domicilio,NombreLocalidad,CodigoPostal,TipoDni,NumeroDni,Telefono from Clientes c,Localidades l where c.IdLocalidad=l.IdLocalidad and IdCliente='" & tbidvendedor.Text & "'"



        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)

        tabla2 = New DataTable
        da.Fill(tabla2)

        textvendedor.Text = tabla2.Rows.Item(0).Item("NombreC")
        texttipov.Text = tabla2.Rows.Item(0).Item("TipoDni")
        textdniv.Text = tabla2.Rows.Item(0).Item("NumeroDni")
        
    End Sub

    Private Sub textsumaentregas_TextChanged(sender As Object, e As EventArgs) Handles textsumaentregasv.TextChanged
        
       
    End Sub

    Private Sub textsumaentrega_TextChanged(sender As Object, e As EventArgs) Handles textsumaentrega.TextChanged
        'Dim entregasv As Decimal = textsumaentregasv.Text
        'Dim entrega As Decimal = textsumaentrega.Text
        'Dim documentos As Decimal = textsumadocumentos.Text
        'Dim precioventa As Decimal = tbPrecioVentaVehVenta.Text
        'Dim administrador As Decimal = TextAdministrador.Text
        'Dim plan As Decimal = TextPlan.Text
        '

        'TextFinanciado.Text = precioventa - documentos - entrega - entregasv - administrador - plan
    End Sub

    Private Sub textsumadocumentos_TextChanged(sender As Object, e As EventArgs) Handles textsumadocumentos.TextChanged
        'Dim entregasv As Decimal = textsumaentregasv.Text
        'Dim entrega As Decimal = textsumaentrega.Text
        'Dim documentos As Decimal = textsumadocumentos.Text
        'Dim precioventa As Decimal = tbPrecioVentaVehVenta.Text
        'Dim administrador As Decimal = TextAdministrador.Text
        'Dim plan As Decimal = TextPlan.Text


        '        TextFinanciado.Text = precioventa - documentos - entrega - entregasv - administrador - plan
    End Sub

    Private Sub TextAdministrador_TextChanged(sender As Object, e As EventArgs) Handles TextAdministrador.TextChanged
        'Dim entregasv As Decimal = textsumaentregasv.Text
        'Dim entrega As Decimal = textsumaentrega.Text
        'Dim documentos As Decimal = textsumadocumentos.Text
        'Dim precioventa As Decimal = tbPrecioVentaVehVenta.Text
        'Dim administrador As Decimal = TextAdministrador.Text
        'Dim plan As Decimal = TextPlan.Text


        '        TextFinanciado.Text = precioventa - documentos - entrega - entregasv - administrador - plan
    End Sub

    Private Sub TextPlan_TextChanged(sender As Object, e As EventArgs) Handles TextPlan.TextChanged
        'Dim entregasv As Decimal = textsumaentregasv.Text
        'Dim entrega As Decimal = textsumaentrega.Text
        'Dim documentos As Decimal = textsumadocumentos.Text
        'Dim precioventa As Decimal = tbPrecioVentaVehVenta.Text
        'Dim administrador As Decimal = TextAdministrador.Text
        'Dim plan As Decimal = TextPlan.Text


        'TextFinanciado.Text = precioventa - documentos - entrega - entregasv - administrador - plan
    End Sub

    Private Sub TextCuotas_TextChanged(sender As Object, e As EventArgs) Handles TextCuotas.TextChanged
        'Dim plan As Decimal = TextPlan.Text
        'Dim intereses As Decimal = TextIntereses.Text
        'Dim cuotas As Integer = TextCuotas.Text
        'Dim valorcuota As Decimal = TextValorCuota.Text

        'TextValorCuota.Text = (plan + (plan * intereses) / 100) / cuotas
        'TextImporteTotal.Text = valorcuota * cuotas
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'guardo el plan en la tabla PLANES

        If TextPlan.Text = 0 Then
            MsgBox("No hay importes para generar el plan", MsgBoxStyle.Exclamation)
        Else

            Dim a As Char = "observacion"
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()

            '  Dim cmd As New SqlCommand("insert into Planes values ('" & dtfecha.Value & "','" & TextDetallePlan.Text & "','" & tbIdCliente.Text & "','" & tbPrecioVentaVehVenta.Text & "','" & textsumaentregasv.Text & "','" & textsumaentrega.Text & "','" & textsumadocumentos.Text & "','" & TextPlan.Text & "','" & TextCuotas.Text & "','" & TextIntereses.Text & "','" & TextMeses.Text & "','" & DTprimeraCuota.Value & "','" & TextValorCuota.Text & "','" & TextImporteTotal.Text & "','" & ChkCancelado.Checked & "','" & a & "','" & textidventa.Text & "')", CN)

            Dim precio As Decimal = tbPrecioVentaVehVenta.Text
            Dim entregav As Decimal = textsumaentregasv.Text
            Dim entrega As Decimal = textsumaentrega.Text
            Dim documentos As Decimal = textsumadocumentos.Text
            Dim plan As Decimal = TextPlan.Text
            Dim cuota As Integer = TextCuotas.Text
            Dim intereses As Decimal = TextIntereses.Text
            Dim meses As Integer = TextMeses.Text
            Dim valorcuota As Decimal = TextValorCuota.Text
            Dim total As Decimal = TextImporteTotal.Text





            ' Dim cmd As New SqlCommand("insert into Planes values ('" & dtfecha.Value & "','" & TextDetallePlan.Text & "','" & Conversion.Val(tbIdCliente.Text) & "','" & Conversion.Val(precio) & "','" & Conversion.Val(entregav) & "','" & Conversion.Val(entrega) & "','" & Conversion.Val(documentos) & "','" & Conversion.Val(plan) & "','" & Conversion.Val(cuota) & "','" & Conversion.Val(intereses) & "','" & Conversion.Val(meses) & "','" & DTprimeraCuota.Value & "','" & Conversion.Val(valorcuota) & "','" & Conversion.Val(total) & "','" & ChkCancelado.Checked & "','a','" & Conversion.Val(textidventa.Text) & "')", CN)

            'Dim cmd As New SqlCommand("insert into Planes(fechaplan, Detalleplan,IdCliente, precioventa) values ('" & dtfecha.Value & "','" & TextDetallePlan.Text & "','" & tbIdCliente.Text & "','" & Conversion.Val(precio) & "')", CN)

            Dim cmd As New SqlCommand("insert into Planes (fechaplan, Detalleplan,IdCliente, precioventa, IdVenta) values ('" & dtfecha.Value & "','" & TextDetallePlan.Text & "','" & Conversion.Val(tbIdCliente.Text) & "', '" & Conversion.Val(precio) & "', '" & Conversion.Val(textidventa.Text) & "' )", CN)

            cmd.ExecuteNonQuery()
            'obtengo el numero de plan....

            'busco el codigo de esta venta...o sea el maximo de la tabla ventas
            Dim planes As New SqlCommand("Select max(IdPlan) from Planes", CN)
            Dim codigo As String = planes.ExecuteScalar

            textidplan.Text = codigo


            'genero ahora todo el plan en cuotas...en la tabla CUOTAS...
            Dim cuotas As Integer
            Dim primercuota As Date
            cuotas = 1
            primercuota = DTprimeraCuota.Value

            Do While cuotas <= TextCuotas.Text
                Dim cmde As New SqlCommand("insert into Cuotas (IdPlan, NumeroCuota, ImporteCuota, Fechacuota)values ('" & codigo & "','" & cuotas & "','" & Conversion.Val(TextValorCuota.Text) & "','" & primercuota & "')", CN)
                ' Dim cmde As New SqlCommand("insert into Cuotas values ('" & codigo & "')", CN)
                cmde.ExecuteNonQuery()


                cuotas = cuotas + 1 ' sumo uno a la cuota
                primercuota = primercuota.Date.AddMonths(TextMeses.Text) 'sumo la cantidad de meses entre fechas para obtener la fecha de la proxima cuota
            Loop
        End If

        MsgBox("Plan Generado", MsgBoxStyle.Information)

    End Sub

   
 

   


    

   

 
    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim entregasv As Decimal = textsumaentregasv.Text
        Dim entrega As Decimal = textsumaentrega.Text
        Dim documentos As Decimal = textsumadocumentos.Text
        Dim precioventa As Decimal = tbPrecioVentaVehVenta.Text
        Dim administrador As Decimal = TextAdministrador.Text
        Dim plan As Decimal = TextPlan.Text
        Dim financiado As Decimal
        Dim creditosolicitado As Decimal = textcredsolicitado.Text
        Dim creditootorgado As Decimal = textcredotorgado.Text

        If creditootorgado = 0 Then
            financiado = precioventa - documentos - entrega - entregasv - administrador - plan - creditosolicitado
        Else
            financiado = precioventa - documentos - entrega - entregasv - administrador - plan - creditootorgado

        End If


        TextFinanciado.Text = financiado
    End Sub

   


 
  
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double


        ' Dim Word As Word.Application
        ' Dim Doc As Word.Document
        Dim Tabli As Word.Table
        Dim Rng As Word.Range
        Dim NCol As Integer = DGentregas.ColumnCount
        Dim NRow As Integer = DGentregas.RowCount

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = "BOLETO DE COMPRAVENTA POR MANDATO"
        oPara1.Range.Font.Bold = False
        oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()


        Dim fecha As Date = dtfecha.Value
        Dim vendedor As String = textvendedor.Text
        Dim comprador As String = tbNombre.Text
        Dim tipodni As String = tbTipoDoc.Text
        Dim dni As String = tbNroDoc.Text
        Dim telefono As String = tbTelefono.Text
        Dim domicilio As String = tbDomicilio.Text
        Dim localidad As String = tbLocalidad.Text
        Dim provincia As String = textprovincia.Text


        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.ParagraphFormat.SpaceAfter = 6
        oRng.InsertAfter("En la ciudad de Colón, a los " & fecha.Day & " días del mes de " & MonthName(fecha.Month) & " de " & fecha.Year & ", entre" & _
       " MULTIMARCAS LA TORTUGA de DED S.A., con domicilio real en San Martín 1147 de la ciudad de Colón, Departamento Colón," & _
        " provincia de Entre Ríos. Actuando como mandatario de " & vendedor & " por parte vendedora " & _
        "y por la otra, " & comprador & " " & tipodni & " " & dni & ", teléfono " & telefono & ", domiciliado " & _
        "en " & domicilio & " de la ciudad de " & localidad & ", provincia de " & provincia & " como comprador, convienen en celebrar" & _
        " el presente boleto de compraventa, sujeto a las cláusulas que se exponen:" & _
        "1) El comprador adquiere un vehículo Marca " & tbMarcaVehVenta.Text & ", Modelo " & tbModeloVehVenta.Text & ", Año " & tbAñoVehVenta.Text & ", " & _
        "Tipo " & tbTipoVehVenta.Text & ", Motor N° " & tbMotorVehVenta.Text & ", Chasis N° " & tbChasisVehVenta.Text & ", Dominio " & tbDominioVehVenta.Text & ", " & _
        "en el estado en que se encuentra, declarando el comprador conocer el mismo por haber inspeccionado y probado el vehículo previo a la celebración del presente, " & _
        "renunciando a todo reclamo en tal sentido." & _
        "2) La venta se realiza por la suma total de " & tbPrecioVentaVehVenta.Text & ", pagaderos de la siguiente forma: " & _
        "Entrega el/los siguiente/s auto/s:")
        oRng.InsertParagraphAfter()




        Tabli = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, DGentregas.RowCount, DGentregas.ColumnCount)
        'Agregando Los Campos De La Grilla
        For i As Integer = 1 To NCol
            Tabli.Cell(1, i).Range.Text = DGentregas.Columns(i - 1).Name.ToString
        Next
        'Agregando Los Registros A La Tabla
        For Fila As Integer = 0 To NRow - 2
            For Col As Integer = 0 To NCol - 1
                If DGentregas.Rows(Fila).Cells(Col).Value IsNot DBNull.Value Then
                    Tabli.Cell(Fila + 2, Col + 1).Range.Text = DGentregas.Rows(Fila).Cells(Col).Value
                End If
            Next
            'Incremento
            'ProgressBar1.Increment(1)
        Next
        'Negrita y Kursiva Para Los Nombres De Los Campos
        Tabli.Rows.Item(1).Range.Font.Bold = True
        Tabli.Rows.Item(1).Range.Font.Italic = True
        'Boder De La Tabla
        ' Table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleDot
        ' Table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDot
        ' Table.Borders.InsideColor = WdColor.wdColorBlue
        Rng = oDoc.Bookmarks.Item("\endofdoc").Range



        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2 = oDoc.Content.Paragraphs.Add
        oPara2.Range.Text = ("Contra entrega de la unidad pesos " & textsumaentrega.Text & " y el saldo de pesos pagaderos de la siguiente forma:................" & _
        "3) La transferencia de dominio deberá realizarse dentro de los 30 días a partir de la fecha. Los gastos de transferencia son a cargo " & _
        "del comprador. 4) La falta de pago de dos (2) cuotas hará exigible la cancelación del total de la deuda como de plazo vencido, debiendo abonar el total adeudado con más los intereses " & _
        "moratorios y punitorios adeudados dentro de los cinco (5) días de que fuere intimado, quedando expresamente pactada para la percepción de tales acreencias la vía ejecutiva, sirviendo el presente de título " & _
        "ejecutivo hábil y suficiente. 5) Para el caso de mora en el pago de las sumas pactadas, el comprador deberá abonar junto con el capital adeudado y en concepto de interés punitorio el equivalente al tres " & _
        "porciento mensual de los importes adeudados. 6) Si transcurridos los 30 días de la fecha no se hubiese realizado la transferencia de la unidad adquirida a favor del comprador, la documentación será remitida al titular," & _
        "quien podrá retenerla hasta que se realice la transferencia y/o denunciar la venta en el Registro Nacional de la Propiedad del Automotor, quedando el mandante exonerado de toda responsabilidad " & _
        "por cualquier embargo y/o gravamen que pudiera afectar a ese bien y/o inhibición que pudiera recaer sobre el titular registral. 7) A opción del vendedor se podrá transferir el dominio a favor del " & _
        "comprador, antes del pago total del precio. En este caso el vendedor y/o el mandatario podrán retener la documentación del rodado hasta la cancelación definitiva de la deuda y el comprador no podrá transferir a " & _
        "tercera persona el dominio hasta el cumplimiento total de su obligación. 8) Hasta tanto se transfiera el dominio a favor del comprador, éste se obliga a contratar un seguro de responsabilidad civil por cualquier daño que puediera " & _
        "causar el rodado aquí vendido; pudiendo el vendedor y/o el mandatario contratarlo a costa del primero para el supuesto de que aquel no lo hiciere. 9) Para el caso de arrepentimiento del comprador, quedara a opción del vendedor la facultad " & _
        "de rescindir o no la compra venta; para el caso de que se aceptare la rescisión de la operación y la devolución del rodado, quedarán a favor del vendedor en concepto de reparación de daños por la  rescisión y sin compensación alguna para el comprador, el equivalente " & _
        "al treinta (30) por ciento de las sumas que el comprador hubiese dado en pago; para el supuesto de que el comprador no hubiera abonado sumas por un monto superior al diez (10) por ciento del valor total de la operación, dichos importes quedarán en su totalidad a favor del " & _
        "vendedor, sin compensación alguna para el comprador de acuerdo con lo antes expuesto. 10) A efectos del presente boleto de Compra-Venta, las partes renuncian expresamente al fuero federal y se someten a los Tribunales Ordinarios de Colón. 11) Las partes " & _
        "constituyen domicilio legal a todos los efectos del presente contrato en los denunciados ut supra. 12) El comprador se declara único responsable civil y criminalmente de la conducción del vehículo adquirido, como así también de cualquier tipo de accidente que pudiera ocasionar, " & _
        "además de las infracciones de tránsito a partir del día y hora  " & Date.Now & ". Se firman dos ejemplares de un mismo tenor y a un solo efecto en el lugar y fechas arriba indicados.")
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()




        

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        ' oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        ' oPara2 = oDoc.Content.Paragraphs.Add
        ' oPara2.Range.Text = "En la ciudad de Colón, a los " & fecha.Day & " días del mes de " & fecha.Month & " de " & fecha.Year & ", entre" & _
        '" MULTIMARCAS LA TORTUGA de DED S.A., con domicilio real en San Martín 1147 de la ciudad de Colón, Departamento Colón," & _
        ' " provincia de Entre Ríos. Actuando como mandatario de " & vendedor & " por parte vendedora " & _
        ' "y por la otra," & comprador & " " & tipodni & " " & dni & ", teléfono " & telefono & ", domiciliado" & _
        ' "en " & domicilio & " de la ciudad de " & localidad & ", provincia de " & provincia &
        ' oPara2.Format.SpaceAfter = 6
        ' oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        'oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        'oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:"
        'oPara3.Range.Font.Bold = False
        'oPara3.Format.SpaceAfter = 24
        'oPara3.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        '     Dim r As Integer, c As Integer
        '    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        '    oTable.Range.ParagraphFormat.SpaceAfter = 6
        '   For r = 1 To 3
        'For c = 1 To 5
        'oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
        '  Next
        ' Next
        'oTable.Rows.Item(1).Range.Font.Bold = True
        'oTable.Rows.Item(1).Range.Font.Italic = True

        'Add some text after the table.
        'oTable.Range.InsertParagraphAfter()
        'oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        'oPara4.Range.InsertParagraphBefore()
        'oPara4.Range.Text = "And here's another table:"
        'oPara4.Format.SpaceAfter = 24
        'oPara4.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data, and change the column widths.
        'oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        'oTable.Range.ParagraphFormat.SpaceAfter = 6
        'For r = 1 To 5
        '   For c = 1 To 2
        'oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
        '   Next
        'Next
        'oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        'oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)

        'Keep inserting text. When you get to 7 inches from top of the
        'document, insert a hard page break.
        'Pos = oWord.InchesToPoints(7)
        'oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        'Do
        'oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        'oRng.ParagraphFormat.SpaceAfter = 6
        'oRng.InsertAfter("A line of text")
        'oRng.InsertParagraphAfter()
        'Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
        'oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        'oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
        'oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        'oRng.InsertAfter("We're now on page 2. Here's my chart:")
        'oRng.InsertParagraphAfter()

        'Insert a chart and change the chart.
        'oShape = oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddOLEObject( _
        '    ClassType:="MSGraph.Chart.8", FileName _
        '    :="", LinkToFile:=False, DisplayAsIcon:=False)
        'oChart = oShape.OLEFormat.Object
        'oChart.charttype = 4 'xlLine = 4
        'oChart.Application.Update()
        'oChart.Application.Quit()
        'If desired, you can proceed from here using the Microsoft Graph 
        'Object model on the oChart object to make additional changes to the
        'chart.
        'oShape.Width = oWord.InchesToPoints(6.25)
        'oShape.Height = oWord.InchesToPoints(3.57)

        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        'oRng.InsertParagraphAfter()
        'oRng.InsertAfter("THE END.")

        'All done. Close this form.
        Me.Close()
    End Sub

    Private Sub bBuscarCliente_Click(sender As Object, e As EventArgs) Handles bBuscarCliente.Click
        formBuscarCliente.Show()
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        formadministrador.Show()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        FormPlan.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim plan As Decimal = TextPlan.Text
        Dim intereses As Decimal = TextIntereses.Text
        Dim cuotas As Integer = TextCuotas.Text
        Dim valorcuota As Decimal = TextValorCuota.Text

        TextValorCuota.Text = (plan + (plan * intereses) / 100) / cuotas
        TextImporteTotal.Text = valorcuota * cuotas
    End Sub

   

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        formcreditos.Show()
    End Sub

   
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub
End Class