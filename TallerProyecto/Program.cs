using TallerProyecto.Controller;
using TallerProyecto.View;

namespace TallerProyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear controladores
            ClienteController clienteController = new ClienteController();
            MecanicoController mecanicoController = new MecanicoController();
            MantenimientoController mantenimientoController = new MantenimientoController();
            VehiculoController vehiculoController = new VehiculoController();  


            // Iniciar el formulario principal
            Application.Run(new FrmPrincipal(clienteController, mecanicoController, mantenimientoController, vehiculoController));
        }
    }
}