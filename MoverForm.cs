using System;
using System.Collections.Generic;
using System.Text;
//agregamos los siguientes using´s
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoModernizacion
{
    public class MoverForm
    {
		//Importmos las siguientes librerias
		[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
		public static extern void ReleaseCapture();

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

		//Metodo para mover el form, le pasamos como parametro el form a mover
		public static void MoverFrm(Form pForm)
		{
			//Agregamos los metodos de arriba
			ReleaseCapture();
			SendMessage(pForm.Handle, 0x112, 0xf012, 0);
		}
		public MoverForm()
		{
		}
	}
}
