using Ejercicio_Integral;

namespace Ejercicio_Integral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputadoraVirtual[] computadoras = new ComputadoraVirtual[4];

            computadoras[0] = new procesoDeDatos("proceso1", "5.0.A", "linux", "BD_Clientes_Original", "BD_Clientes_Filtrada");
            computadoras[1] = new procesoDeDatos("proceso2", "8.0.B", "linux", "BD_Ventas_Original", "BD_Ventas_Procesada");
            computadoras[2] = new Aplicacion("app1", "2.0", "Windows 7", "C#", "11.0", "sqlserver://db1");
            computadoras[3] = new Aplicacion("app2", "2.1", "Windows 11", "Python", "3.11", "postgresql://db2");

            Console.WriteLine("LEVANTANDO COMPUTADORAS XD\n");
            foreach (var i in computadoras)
            {
                i.levantar();
                Console.WriteLine();
            }

            Console.WriteLine("LEVANTANDO COMPUTADORAS de nuevooooo XD\n");
            foreach (var i in computadoras)
            {
                i.levantar();
                Console.WriteLine();
            }

            Console.WriteLine("BAJANDO COMPUTADORAS XD\n");
            foreach (var i in computadoras)
            {
                i.bajar();
                Console.WriteLine();
            }

            Console.WriteLine("BAJANDO COMPUTADORAS otra ves XD\n");
            foreach (var i in computadoras)
            {
                i.bajar();
                Console.WriteLine();
            }
        }
    }

    class ComputadoraVirtual
    {
        public string nombre;
        public string version;
        public string sistOperativo;
        public string estado = "down";


        public ComputadoraVirtual() { }

        public ComputadoraVirtual(string nombre, string version, string sistOperativo)
        {
            this.nombre = nombre;
            this.version = version;
            this.sistOperativo = sistOperativo;
        }

        public virtual void levantar()
        {
            if (this.estado == "down")
            {
                this.estado = "up";
                Console.WriteLine($"La computadora virtual {this.nombre} se ha LEVANTADO correctamente");
            }
            else
            {
                Console.WriteLine($"La computadora virtual {this.nombre} ya esta LEVANTADA");
            }

        }
        public virtual void bajar()
        {
            if (this.estado == "up")
            {
                this.estado = "down";
                Console.WriteLine($"La computadora virtual {this.nombre} se ha BAJADO correctamente");
            }
            else
            {
                Console.WriteLine($"La computadora virtual {this.nombre} ya esta bajada");
            }
        }

    }

    class procesoDeDatos : ComputadoraVirtual
    {
        public string DatosDeOrigen;
        public string DatosDeFin;

       public procesoDeDatos() { }

       public procesoDeDatos(string nombre, string version, string sistOperativo, string DatosDeOrigen,string DatosDeFin) :base (nombre, version,sistOperativo) 
        { 
            this.DatosDeOrigen = DatosDeOrigen;
            this.DatosDeFin = DatosDeFin;
        }

        public override void levantar()
        {
            if (this.estado == "down")
            {
                this.estado = "up";
                Console.WriteLine($"La computadora virtual {this.nombre} se ha LEVANTADO correctamente, posee acesso a los datos de origen: {this.DatosDeOrigen}y a los datos de fin : {this.DatosDeFin}");
            }
            else
            {
                Console.WriteLine($"La computadora virtual {this.nombre} ya esta LEVANTADA");
            }

        }
        
        }

    }


class Aplicacion : ComputadoraVirtual
{
    public string lengProgramcion;
    public string VersionLenguaje;
    public string BaseDeDatos;

    public Aplicacion() { }

    public Aplicacion(string nombre, string version, string sistOperativo, string lengProgramcion, string VersionLenguaje, string BaseDeDatos) : base(nombre, version, sistOperativo)
    {
        this.lengProgramcion = lengProgramcion;
        this.VersionLenguaje = VersionLenguaje;
        this.BaseDeDatos = BaseDeDatos;
    }

    public override void levantar()
    {
        if (this.estado == "down")
        {
            this.estado = "up";
            Console.WriteLine($"La computadora virtual {this.nombre} se ha LEVANTADO correctamente, se intalo el lenguaje de programacion: {this.lengProgramcion} en la version:{this.VersionLenguaje} y posee acceso a la base de datos: {this.BaseDeDatos} ");
        }
        else
        {
            Console.WriteLine($"La computadora virtual {this.nombre} ya esta LEVANTADA");
        }

    }

}

    


