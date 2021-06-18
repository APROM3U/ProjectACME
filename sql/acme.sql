create table tb_voo (
	id_voo		int identity,
	data_voo	datetime		not null,
	custo		decimal (10,2)	not null,
	distancia	int				not null,
	captura		char(1)			not null,
	nivel_dor	int				not null
)