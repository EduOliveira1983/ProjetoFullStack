create table rua_cep (id_rua_cep int not null primary key identity,
					  id_rua int not null foreign key references rua(id_rua),
					  cep varchar(10) not null,
					  numero_inicial int not null,
					  numero_final int,
					  obs varchar(200),
					  data_cadastro datetime not null default getdate())					  

create unique index ix_rua_cep on rua_cep(id_rua, cep, numero_inicial, numero_final)