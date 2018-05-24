--como não deixei fixo o id do pais, então segue um gato para poder buscar o id do 
--pais e executar o script corretamente
declare @id_pais int
select	@id_pais = id_pais
from	pais
where	sigla = 'BR'

INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,12,'AC','Acre');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,27,'AL','Alagoas');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,13,'AM','Amazonas');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,16,'AP','Amapá');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,29,'BA','Bahia');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,23,'CE','Ceará');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,53,'DF','Distrito Federal');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,32,'ES','Espírito Santo');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,52,'GO','Goiás');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,21,'MA','Maranhão');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,31,'MG','Minas Gerais');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,50,'MS','Mato Grosso do Sul');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,51,'MT','Mato Grosso');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,15,'PA','Pará');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,25,'PB','Paraíba');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,26,'PE','Pernambuco');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,22,'PI','Piauí');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,41,'PR','Paraná');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,33,'RJ','Rio de Janeiro');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,24,'RN','Rio Grande do Norte');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,11,'RO','Rondônia');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,14,'RR','Roraima');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,43,'RS','Rio Grande do Sul');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,42,'SC','Santa Catarina');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,28,'SE','Sergipe');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,35,'SP','São Paulo');
INSERT INTO ESTADO (id_pais,codigo_ibge,SIGLA,NOME) values (@id_pais,17,'TO','Tocantis');