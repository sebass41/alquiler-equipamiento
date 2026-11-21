using System;

public class Pedido
{
	public int Id { get; set; }
	public string MetodoEntrega { get; set; }
	public string Comentarios { get; set; }
	public int Puntuacion { get; set; }
	public Date FechaInicio { get; set; }
	public Date FechaFin { get; set; }

    public Pedido()
	{
	}
}
