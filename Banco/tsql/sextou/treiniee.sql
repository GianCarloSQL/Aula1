--Trazer somente as marcas que Felipe cadastrou
select m.Nome 
	from Marcas m inner join Usuarios u on m.UsuInc = u.Id
where u.Usuario like 'Felipe%'

--Trazer somente as marcas que Giomar cadastrou
select m.Nome from Marcas m inner join Usuarios u on m.UsuInc =u.Id
where u.Usuario like 'Giomar%';

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor "colocar o order by desc   no final do select só isso "
select m.Nome, u.Usuario from Marcas m
inner join Usuarios u on u.Id = m.UsuInc
where u.Usuario like 'Felipe%' 
order by m.Nome desc

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select m.Nome, u.Usuario from Marcas m
inner join Usuarios u on u.Id = m.UsuInc
where u.Usuario like 'Giomar%' 
order by m.Nome asc

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select m.Nome, u.Usuario from Marcas m
inner join Usuarios u on u.Id = m.UsuInc
where u.Usuario like 'Felipe%' or u.Usuario like 'Giomar%'
group by m.Nome, u.Usuario 
order by u.Usuario

--Trazer somente os carros que Felipe cadastrou
select c.Modelo,m.Nome as 'Marca', year(c.Ano) from Carros c
inner join Marcas m on m.Id = c.Marca
inner join Usuarios u on c.UsuInc = u.Id
where c.UsuInc = 1;
--Trazer somente os carros que Giomar cadastrou
select c.Modelo,m.Nome as 'Marca', year(c.Ano) from Carros c
inner join Marcas m on m.Id = c.Marca
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Giomar%';

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select count(c.Id) as 'Quantidade',u.Usuario from Carros c
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Felipe%'
group by u.Usuario
order by u.Usuario desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select count(c.Id) as 'Quantidade',u.Usuario from Carros c
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Giomar%'
group by u.Usuario
order by u.Usuario asc;

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select count(c.Id) as 'Quantidade',u.Usuario from Carros c
inner join Usuarios u on c.UsuInc = u.Id
group by u.Usuario
order by u.Usuario asc;

--Trazer somente os carros das marcas que Felipe cadastrou
select c.Modelo from  Carros c
inner join Usuarios u on c.UsuInc = u.Id
inner join Marcas m on m.Id = c.Marca
where m.UsuInc =1;

--Trazer somente os carros das marcas que Giomar cadastrou
select c.Modelo from  Carros c
inner join Usuarios u on c.UsuInc = u.Id
inner join Marcas m on m.Id = c.Marca
where m.UsuInc =2;

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select count(c.Id) as 'Quantidade' from Carros c
inner join Usuarios u on c.UsuInc =u.Id
inner join Marcas m on m.Id = c.Marca
where m.UsuInc = 1
order by count(c.Id) desc;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select count(c.Id) as 'Quantidade' from Carros c
inner join Usuarios u on c.UsuInc =u.Id
inner join Marcas m on m.Id = c.Marca
where m.UsuInc = 2
order by count(c.Id) desc;

--Trazer o valor total de vendas 2019 isolado
select sum(v.Quantidade*v.Valor) as 'Valor Total' from Vendas v

--Trazer a quantidade total de vendas 2019 isolado

--Trazer  a marca mais vendida de todos os anos

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor


--Trazer  a marca mais vendida de todos os anos

--Trazer o valor total de vendas 2019 isolado
