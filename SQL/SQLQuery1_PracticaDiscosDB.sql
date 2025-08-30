select d.Titulo, d.FechaLanzamiento, e.Descripcion as Estilo from DISCOS d, ESTILOS e
where e.Id = d.IdEstilo

insert into ESTILOS (Descripcion) values ('Folk')
insert into ESTILOS (Descripcion) values ('Metal')

select * from ESTILOS
select * from TIPOSEDICION

select * from DISCOS;
select Descripcion from ESTILOS e, DISCOS d where e.id = d.IdEstilo 

select d.Titulo, e.Descripcion as Estilo, t.Descripcion as Edicion 
from DISCOS d, ESTILOS e, TIPOSEDICION t where d.IdEstilo = e.Id AND t.Id = d.IdTipoEdicion;

select * from DISCOS where Titulo like '%so%'

insert into TIPOSEDICION values ('Digital');
insert into DISCOS values 
('Somewhere in time', GETDATE(), 8, 'https...', 17, 4 )
insert into DISCOS values 
('X factor', GETDATE(), 12, 'https', 17, 2)

update DISCOS set FechaLanzamiento = '1985-09-24' where id = 7

delete from ESTILOS where Id = 12
delete from DISCOS where id = 8;