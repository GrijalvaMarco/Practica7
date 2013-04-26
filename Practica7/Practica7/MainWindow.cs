using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


	
	protected void OnBotonTerminarClicked (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
		int puntos=0;
		
		//pregunta 1
		if(this.radiobutton1.Active)
			puntos++;
		if(this.radiobutton2.Active)
			puntos++;
		if(this.radiobutton3.Active)
			puntos++;
		if(this.radiobutton4.Active)
			puntos++;
		
		
		//pregunta 2
		if(this.spinbutton1.Text=="4")
			puntos++;
		
		
		//pregunta 3
		if(this.checkOpc1.Active){
			puntos++;
		}
		if(this.checkOpc4.Active){
			puntos++;
		}
		
		
		//pregunta 4
		
		DateTime fecha = this.calendar1.GetDate();
		string fechaSeleccionada = fecha.ToShortDateString();
		if(fechaSeleccionada=="16/09/1810"){
		puntos++;	
		}
		
		//mensaje en pantalla
		
		MessageDialog mensaje = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "obtuviste :"+puntos+" aciertos!");
		mensaje.Show();
		
	
		
	}
}


