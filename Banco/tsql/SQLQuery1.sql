update Usuario set login = 'NULL' where Login is null;


insert into dbo.Livro 
(Titulo) values ('The fisherman'), ('the sky');

select Name,Id from Usuario where Usuario.Aivo =1;


-- pega o ultimo registro da tabela 
update Livro set Ativo =1 where id =
(SELECT id FROM Livro ORDER BY id desc OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY);

select * from Livro ;
