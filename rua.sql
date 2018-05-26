declare @id_bairro int
declare @id_tipo_logradouro int

select @id_bairro = bar.id_bairro
from   bairro bar
inner	join cidade cid on bar.id_cidade = cid.id_cidade
where	bar.nome = 'MUTINGA'
and		cid.nome = 'OSASCO'

select	@id_tipo_logradouro = id_tipo_logradouro
from	tipo_logradouro
where	descricao = 'RUA'

insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'ABAS-Associação Brasileira dos Artistas Sertanejos','06286082')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Água Marinha','06280000')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Alemanha','06286150')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Amazonita','06286060')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Âmbar','06286310')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Ametista','06286220')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Berilo','06286270')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Brilhante','06286130')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Calcedônia','06286170')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Carlos Alberto Rossato','06286090')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Cassiterita','06286050')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Comendador Afonso Vaz Morais','06286040')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Coral','06280190')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Crisólito','06286230')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Diamante','06286140')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Espanha','06286180')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Eurides Gregório','06286020')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Fortunato Pulherini','06286080')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Granada','06280180')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Haroldo Cardoso','06286030')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Heliotrópio','06286120')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Inglaterra','06286160')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Jade','06286190')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Jaspe','06280210')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Marfim','06280220')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Morganita','06286070')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Olho de Tigre','06286300')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Opala','06286110')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Otávio Schianti','06280010')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Pérola','06280230')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Platina','06286005')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Portugal','06286335')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Professor Acácio Canto Júnior','06286084')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Rubi','06286200')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Rumânia','06286330')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Safira','06286210')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Sardônica','06286260')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Selemita','06286280')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Suíça','06286290')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Titanita','06286320')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Topázio','06286240')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Turmalina','06286250')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Turquesa Azul','06286100')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Waldemir Carvalho de Sena','06280020')

select	@id_tipo_logradouro = id_tipo_logradouro
from	tipo_logradouro
where	descricao = 'AVENIDA'

insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'das Esmeraldas','06286010')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Luiz Rink','06286000')

select	@id_tipo_logradouro = id_tipo_logradouro
from	tipo_logradouro
where	descricao = 'PRAÇA'

insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Idalino Andriolo','06280200')

select	@id_tipo_logradouro = id_tipo_logradouro
from	tipo_logradouro
where	descricao = 'VIELA'

insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Arminda Albano Teixeira','06280002')
insert into rua (id_bairro, id_tipo_logradouro, nome, cep) values( @id_bairro,@id_tipo_logradouro,'Viela Carlos José Almeida Santos','06286115')

