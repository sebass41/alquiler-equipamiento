using System;

public class Evento
{
	public int Id { get; set; }
	public int CantidadAsistentes { get; set; }
	public DateTime Fecha { get; set; }
	public int HoraInicio { get; set; }
	public int HoraFin { get; set; }

    public Evento()
	{
	}
}
