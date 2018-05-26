declare @id_cidade int
select  @id_cidade  = id_cidade
from	cidade cid
inner	join estado uf on uf.id_estado = cid.id_estado
where	cid.nome = 'OSASCO'
and		uf.sigla = 'SP'

select @id_cidade

Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401001','Jardim das Flores',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401002','Km 18',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401003','Centro',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401004','Vila Osasco',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401005','Industrial Centro',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401006','Cipava',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401007','Vila Yolanda',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401008','Pestana',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401009','Setor Militar',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401010','Bonfim',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401011','Presidente Altino',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401012','Industrial Autonomistas',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401013','Parque Continental',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401014','Vila Campesina',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401015','Cidade de Deus',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401016','Piratininga',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401017','Rochale',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401018','Vila Yara',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401019','Bela Vista',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401020','Jardim Roberto',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401021','Iapi',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401022','Ayrosa',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401023','Industrial Remédios',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401024','Industrial Altino',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401025','Adalgisa',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401026','Umuarama',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401027','Cidade das Flores',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401028','Vila Militar',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401029','Castelo Branco',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401030','Remédios',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401031','Santo Antônio',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401032','Jardim Elvira',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401033','Aliança',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401034','Jardim D''Abril',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401035','Jaguaribe',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401036','São Pedro',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401037','Quintauna',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401038','Munhoz Júnior',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401039','Industrial Mazzei',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401040','Mutinga',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401041','Padroeira',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401042','Helena Maria',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401043','Baronesa',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401044','Vila Menk',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401045','Bussocaba',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401046','Veloso',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401047','Bandeiras',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401048','Portal D''Oeste',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401049','Industrial Anhanguera',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401050','City Bussocaba',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401051','Jardim Novo Osasco',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401052','Bonança',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401053','Platina',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401054','Metalúrgicos',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401055','Paiva Ramos',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401056','Três Montanhas',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401057','Jardim Conceição',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401058','Santa Fé',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401059','Raposo Tavares',@id_cidade);
Insert into Bairro (codigo_ibge, Nome, id_cidade) values ('3534401060','Santa Maria',@id_cidade);