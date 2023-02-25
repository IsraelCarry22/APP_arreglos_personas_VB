Imports System

Module Program
    Sub Main(args As String())
        Dim numero_contactos As Integer = 0
        Console.WriteLine("=====AGENDA DE PERSONAS=====" & vbLf)
        Console.Write("Ingrese la cantidad de contactos que quiere agregar: ")
        numero_contactos = Integer.Parse(Console.ReadLine())
        Dim Personas As Contac() = New Contac(numero_contactos - 1) {}
        Console.Clear()

        For i As Integer = 0 To numero_contactos - 1
            Console.WriteLine("=====CONTACTO =====" & vbLf)
            Dim Agenda As Contac = New Contac()
            Console.Write("Ingresa el Nombre: ")
            Agenda.Nombre = Console.ReadLine()
            Console.Write("Ingresa tu Apellido paterno: ")
            Agenda.Apellido_Paterno = Console.ReadLine()
            Console.Write("Ingresa el Apellido materno: ")
            Agenda.Apellido_Materno = Console.ReadLine()
            Console.Write("Ingresa tu Fecha de cumpleaños (DD/MM/AAAA): ")
            Agenda.Fecha_de_cumpleaños = DateTime.Parse(Console.ReadLine())
            Console.Write("Ingresa tu Correo: ")
            Agenda.Correo = Console.ReadLine()
            Console.Write("Ingresa tu Telefono: ")
            Agenda.Telefono = Console.ReadLine()
            Personas(i) = Agenda
            Console.Clear()
        Next

        For i As Integer = 0 To numero_contactos - 1
            Console.WriteLine("Contacto #" & (i + 1))
            Console.WriteLine(Personas(i).ToString() & vbLf)
        Next

        Console.WriteLine("Pulse entre para salir...")
        Console.ReadKey()
    End Sub
End Module
