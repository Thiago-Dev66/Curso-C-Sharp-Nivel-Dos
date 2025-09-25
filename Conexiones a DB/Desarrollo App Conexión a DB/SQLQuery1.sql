select * from DISCOS

select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa as Cover, e.Descripcion as Estilo, t.Descripcion as Formato from DISCOS D, ESTILOS E, TIPOSEDICION T where e.Id = IdEstilo and t.Id = IdTipoEdicion 

select * from ESTILOS, TIPOSEDICION