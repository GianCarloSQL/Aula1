﻿-- Realizar um update das informações que contem usuario de criação 0 para o Id do usuario Felipe
update Marcas set UsuInc = 1 where UsuInc =0;

-- Trazer somente as marcas que Felipe cadastrou
select * from Marcas m 
inner join Usuarios u on m.UsuInc = u.Id
where u.Usuario like 'Felipe'; 

-- Trazer somente as marcas que Giomar cadastrou
select * from Marcas m 
inner join Usuarios u on m.UsuInc = u.Id
where u.Usuario like 'Giomar'; 

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor 
--"so colocar o desc mesmo não fazendo sentido"
select Count(m.Id) as'Quantidade' from Marcas m 
inner join Usuarios u on m.UsuInc = u.Id
where u.Usuario like 'Felipe' order by count(m.Id) desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select Count(m.Id) as'Quantidade' from Marcas m 
inner join Usuarios u on m.UsuInc = u.Id
where u.Usuario like 'Giomar' order by count(m.Id) asc;

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select Count(m.Id) as'Quantidade' from Marcas m 
inner join Usuarios u on m.UsuInc = u.Id
where u.Usuario like 'Giomar' or u.Usuario = 'Felipe';

--Trazer somente os carros que Felipe cadastrou
select * from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Felipe';

--Trazer somente os carros que Giomar cadastrou
select * from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Giomar';

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select Count(c.Id) as'Quantidade' from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Felipe' order by count(c.Id) desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select Count(c.Id) as'Quantidade' from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
where u.Usuario like 'Giomar' order by count(c.Id) asc;

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select Count(c.Id) as'Quantidade', u.Usuario from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
where u.Id =1 or u.Id =2
group by u.Usuario 


--Trazer somente os carros das marcas que Felipe cadastrou
select * from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
inner join Marcas m on c.Marca = m.Id
where u.Id = 1 and m.UsuInc =1;

--Trazer somente os carros das marcas que Giomar cadastrou
select * from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
inner join Marcas m on c.Marca = m.Id
where u.Id = 2 and m.UsuInc =2;

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select count(c.Id) as 'Quantidade' from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
inner join Marcas m on c.Marca = m.Id
where u.Id = 1 and m.UsuInc =1
order by COUNT(c.Id) desc;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select count(c.Id) as 'Quantidade' from Carros c 
inner join Usuarios u on c.UsuInc = u.Id
inner join Marcas m on c.Marca = m.Id
where u.Id = 2 and m.UsuInc =2
order by COUNT(c.Id) asc;

--Trazer o valor total de vendas 2019 isolado
select sum(v.Valor*Quantidade) as 'Valor Total Vendas 2019' from Vendas v
where v.DatInc like  '%2019%';

--Trazer a quantidade total de vendas 2019 isolado
select count(v.Valor) as 'Quantidade Vendas 2019' from Vendas v
where v.DatInc like  '%2019%';

--trazer o valor total de vendas em cada ano e ordenar do maior para o menor	
select sum(Valor) as 'Total Value each year', Year(DatInc) as 'Ano'from Vendas 
where DatInc like '%2018%' or DatInc like '%2019%'or DatInc like '%2020%'
group by year(DatInc) 
order by sum(valor) desc
--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select count(Valor) as 'Quantidade de Vendas', Year(DatInc) as 'Ano'from Vendas 
where DatInc like '%2018%' or DatInc like '%2019%'or DatInc like '%2020%'
group by year(DatInc) 
order by count(valor) desc

--Trazer o mes de cada ano que teve a maior quantidade de vendas
SELECT year(ven1.DatInc),
(	SELECT TOP 1 MONTH(ven.DatInc) FROM Vendas ven
     WHERE year(ven.DatInc) = year(ven1.DatInc)
  GROUP BY month(ven.DatInc)
  ORDER BY sum(ven.Quantidade) DESC)
FROM Vendas ven1
GROUP BY year(ven1.DatInc)

		
--Trazer o mês de cada ano que retornou o maior valor de vendas
		-- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
select max(Valor) as 'Quantidade', Year(DatInc) as 'Ano' from Vendas
group by Year(DatInc)
order by  max(Valor) desc;

--Trazer o valor total de vendas que Felipe realizou
select SUM(v.Valor) as 'Total vendas',u.Usuario from Vendas v
inner join Usuarios u on u.Id = v.UsuInc
where u.Id = 1
group by u.Usuario

--Trazer o valor total de vendas que Giomar realizou
select SUM(v.Valor) as 'Total vendas',u.Usuario from Vendas v
inner join Usuarios u on u.Id = v.UsuInc
where u.Id = 2
group by u.Usuario

--Trazer a quantidade total de vendas que Felipe realizou
select count(v.Valor) as 'Total vendas',u.Usuario from Vendas v
inner join Usuarios u on u.Id = v.UsuInc
where u.Id = 1
group by u.Usuario

--Trazer a quantidade de vendas que Giomar realizou
select count(v.Valor) as 'Total vendas',u.Usuario from Vendas v
inner join Usuarios u on u.Id = v.UsuInc
where u.Id = 2
group by u.Usuario

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select count(v.Valor) as 'Total vendas',u.Usuario from Vendas v
inner join Usuarios u on u.Id = v.UsuInc
group by u.Usuario
order by count(v.Valor) desc

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select sum(v.Valor) as 'Total vendas',u.Usuario from Vendas v
inner join Usuarios u on u.Id = v.UsuInc
group by u.Usuario
order by sum(v.Valor) desc

--Trazer  a marca mais vendida de todos os anos
select top 1 count(v.Valor) as 'Vendas' ,m.Nome from Carros c
inner join Marcas m on m.Id = c.Marca
inner join Vendas v on v.Carro = c.Id
group by  m.Nome 
order by count(v.Valor) desc

--		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
--Trazer o valor total da marca mais vendida de todos os anos		
select top 1 sum(v.Valor*v.Quantidade) as 'Vendas' ,m.Nome from Carros c
inner join Marcas m on m.Id = c.Marca
inner join Vendas v on v.Carro = c.Id
group by  m.Nome 
order by sum(v.Valor*v.Quantidade) desc	

--Trazer a quantidade do carro mais vendido de todos os anos
select top 1 sum(v.Quantidade) as 'Venda', v.Carro from Vendas v
inner join Carros c on v.Carro = c.Id
group by v.Carro
order by sum(v.Quantidade) desc

--Trazer o valor do carro mais vendido de todos os anos
SELECT top 1 avg(ve.Valor) as 'Valor' FROM VENDAS ve
inner join CARROS ca on ve.Carro = ca.Id
inner join Marcas ma on ca.Marca = ma.Id
group by ca.Modelo 
order by sum(ve.Quantidade) desc
