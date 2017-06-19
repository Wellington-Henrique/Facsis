CREATE TABLE pessoa (
id_pessoa serial PRIMARY KEY NOT NULL,
nome varchar(120) NOT NULL,
tipo_pessoa varchar(10) NOT NULL,
email varchar(120) NOT NULL,
telefone varchar(15) NOT NULL,
endereco varchar(120) NOT NULL,
numero_imovel integer NOT NULL,
cidade varchar(120) NOT NULL,
uf varchar(2) NOT NULL,
cpf_cnpj varchar(15) UNIQUE NOT NULL,
relacao varchar(12) NOT NULL
);

CREATE TABLE produto (
id_produto serial PRIMARY KEY NOT NULL,
nome varchar(120) NOT NULL,
fornecedor varchar(50) NOT NULL,
medida varchar(2) NOT NULL,
status varchar(7) NOT NULL,
ultima_compra Date NOT NULL,
descricao varchar(200) NOT NULL,
preco numeric(7,2) NOT NULL
);

CREATE TABLE estoque (
id_produto integer PRIMARY KEY NOT NULL,
quantidade integer NOT NULL,
locacao varchar(20) NOT NULL,
FOREIGN KEY(id_produto) REFERENCES produto (id_produto)
);

CREATE TABLE usuario (
id_usuario serial PRIMARY KEY NOT NULL,
nome varchar(150) NOT NULL,
email varchar(50) NOT NULL,
telefone varchar(50) NOT NULL,
nivel varchar(20) NOT NULL
);

CREATE TABLE acesso (
id_login integer PRIMARY KEY NOT NULL,
login_usuario varchar(100) UNIQUE NOT NULL,
senha varchar(100) NOT NULL,
CONSTRAINT id_login FOREIGN KEY (id_login) REFERENCES usuario (id_usuario)
);

CREATE TABLE venda (
id_venda serial PRIMARY KEY  NOT NULL,
id_usuario integer NOT NULL,
id_pessoa integer NOT NULL,
FOREIGN KEY(id_usuario) REFERENCES usuario (id_usuario),
FOREIGN KEY(id_pessoa) REFERENCES pessoa (id_pessoa),
data_nota date NOT NULL,
data_pedido date NOT NULL,
status varchar(9) NOT NULL,
forma_pagamento varchar(10) NOT NULL,
valor_total numeric(7, 2) NOT NULL
);

CREATE TABLE itens_pedido (
id_itens_pedido serial PRIMARY KEY NOT NULL,
id_venda integer NOT NULL,
id_produto integer NOT NULL,
quantidade integer NOT NULL,
vlr_unitario numeric(7, 2) NOT NULL,
CONSTRAINT id_venda FOREIGN KEY(id_venda) REFERENCES venda (id_venda),
FOREIGN KEY(id_produto) REFERENCES estoque (id_produto)
);

INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('JOÃO CARLOS', 'Física', 'joão.carlos@net.com', '15997435225', 'Rua 1', 512, 'ITAPETININGA', 'SP', '11111111111', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('MARIA SILVA', 'Física', 'maria@net.com', '15997435225', 'Rua 1', 550, 'ITAPETININGA', 'SP','33333333333', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('GIOVANA SANTOS', 'Física', 'giovana@net.com', '15997435225', 'Rua 2', 1120, 'ITAPETININGA', 'SP', '22222222222', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('JOÃO MIGUEL', 'Física', 'joão.miguel@net.com', '15997333333', 'Rua 10', 2510, 'ITAPETININGA', 'SP','44444444444', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('JOÃO LOURENÇO', 'Física', 'joão.lourenco@net.com', '15997444444', 'Rua 12', 2610, 'ITAPETININGA', 'SP','88888888888', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('LUANA SILVA', 'Física', 'luana.silva@net.com', '15997999225', 'Rua 16', 3355, 'ITAPETININGA', 'SP','99999999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('LUANA DIAS', 'Física', 'luana.dias@net.com', '15996555225', 'Rua 515', 3399, 'ITAPETININGA', 'SP','99999999922', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('CAROLINA SILVA', 'Física', 'carolina.silva@net.com', '15996435225', 'Rua 116', 2315, 'ITAPETININGA', 'SP','99999119999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('MARIA EDUARDA', 'Física', 'maria.eduarda@net.com', '15996125225', 'Rua 14', 3510, 'ITAPETININGA', 'SP','99999929999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('CAROLINE MENDES', 'Física', 'caroline.mendes@net.com', '15998935225', 'Rua 21', 3514, 'ITAPETININGA', 'SP','99999399999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('RICARDO MELO', 'Física', 'ricardo.melo@net.com', '15998435225', 'Rua 90', 3561, 'ITAPETININGA', 'SP','99979999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('PAULO SANTOS', 'Física', 'paulo.santos@net.com', '15997485225', 'Rua 10', 3716, 'ITAPETININGA', 'SP','99999996999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('MARIO NEVES', 'Física', 'mario.neves@net.com', '15997435888', 'Rua 415', 12, 'ITAPETININGA', 'SP','99999999299', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('RICARDO SANTOS', 'Física', 'ricardo.santos@net.com', '15997435712', 'Rua 160', 29, 'ITAPETININGA', 'SP','99999999993', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('GIOVANE HENRIQUE', 'Física', 'giovane.henrique@net.com', '15991231231', 'Rua 53', 475, 'ITAPETININGA', 'SP','94999999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('MAURO BERNARDES', 'Física', 'mauro.bernardes@net.com', '15991234225', 'Rua 15', 250, 'ITAPETININGA', 'SP','99969999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('MARIANA MELO', 'Física', 'mariana.melo@net.com', '15998915225', 'Rua 113', 560, 'ITAPETININGA', 'SP','39999999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('CARLOS EDUARDO', 'Física', 'carlos.eduardo@net.com', '15998035225', 'Rua 101', 610, 'ITAPETININGA', 'SP','99399999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('PAULO DIAS', 'Física', 'paulo.dias@net.com', '15997433335', 'Rua 161', 915, 'ITAPETININGA', 'SP','92999999999', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('LUCAS SILVA', 'Física', 'lucas.silva@net.com', '1599765435225', 'Rua 170', 980, 'ITAPETININGA', 'SP','99999999979', 'CLIENTE');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA 1', 'Jurídica', 'empresa1@net.com', '1533751315', 'Rua 9', 980, 'ITAPETININGA', 'SP','000999999979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA 2', 'Jurídica', 'empresa2@net.com', '1133751402', 'Rua 25', 980, 'SÃO CAETANO', 'SP','000999992979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA 3', 'Jurídica', 'empresa3@net.com', '1133759999', 'Rua 12', 980, 'SÃO BERNARDO', 'SP','000993999979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA 4', 'Jurídica', 'empresa4@net.com', '1533751224', 'Rua 360', 980, 'SOROCABA', 'SP','000999949979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA 5', 'Jurídica', 'empresa5@net.com', '1533751536', 'Rua 4', 980, 'ITU', 'SP','000999996979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA 6', 'Jurídica', 'empresa6@net.com', '1533751420', 'Rua 4', 980, 'ARAÇOIABA DA SERRA', 'SP','000499999979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA X', 'Jurídica', 'empresa7@net.com', '1533751311', 'Rua 450', 980, 'ITAPETININGA', 'SP','000919999979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA Y', 'Jurídica', 'empresa8@net.com', '1133751322', 'Rua 90', 980, 'SÃO PAULO', 'SP','000969999979', 'FORNECEDOR');
INSERT INTO pessoa(nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao) values('EMPRESA N', 'Jurídica', 'empresa9@net.com', '1533751631', 'Rua 31', 980, 'MINAS GERAIS', 'SP','020999999979', 'FORNECEDOR');

INSERT INTO usuario(nome, email, telefone, nivel) values('ADMINISTRADOR', '@', '@', 'Administrador');
INSERT INTO acesso(id_login, login_usuario, senha) values(1, 'adm', '123');
INSERT INTO usuario(nome, email, telefone, nivel) values('VENDEDOR', '@', '@', 'Vendedor');
INSERT INTO acesso(id_login, login_usuario, senha) values(2, 'ven', '123');
INSERT INTO usuario(nome, email, telefone, nivel) values('ESTOQUISTA', '@', '@', 'Estoquista');
INSERT INTO acesso(id_login, login_usuario, senha) values(3, 'est', '123');
INSERT INTO usuario(nome, email, telefone, nivel) values('WELLINGTON', 'wellington@net.com', '15997999999', 'Administrador');
INSERT INTO acesso(id_login, login_usuario, senha) values(4, 'wellington', '123');
INSERT INTO usuario(nome, email, telefone, nivel) values('MARIA', 'maria@net.com', '15998664485', 'Vendedor');
INSERT INTO acesso(id_login, login_usuario, senha) values(5, 'maria', '123');
INSERT INTO usuario(nome, email, telefone, nivel) values('CARLOS', '15996134488', '@', 'Estoquista');
INSERT INTO acesso(id_login, login_usuario, senha) values(6, 'carlos', '123');

INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('MOUSE', 'EMPRESA 1', 'UN', 'ATIVO', '2017-03-10', 'MOUSE USB', 40.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(1, 20, 'Prateleira 1');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('TECLADO', 'EMPRESA 2', 'UN', 'ATIVO', '2017-03-10', 'TECLADO USB', 30.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(2, 10, 'Prateleira 1');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('CABO VGA', 'EMPRESA 3', 'UN', 'ATIVO', '2017-03-10', 'PC/NOTEBOOK', 20.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(3, 100, 'Prateleira 1');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('MOUSE', 'EMPRESA 2', 'UN', 'ATIVO', '2017-03-10', 'MOUSE SEM FIO', 40.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(4, 10, 'Prateleira 1');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('MOUSE', 'EMPRESA 2', 'UN', 'ATIVO', '2017-03-10', 'MOUSE USB', 40.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(5, 20, 'Prateleira 1');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('MONITOR LCD', 'EMPRESA 3', 'UN', 'ATIVO', '2017-03-10', 'MONITOR 17"', 600.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(6, 5, 'Prateleira 2');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('MONITOR LCD', 'EMPRESA 3', 'UN', 'ATIVO', '2017-03-10', 'MONITOR 14"', 350.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(7, 5, 'Prateleira 2');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('MOUSE', 'EMPRESA 4', 'UN', 'ATIVO', '2017-03-10', 'MOUSE USB', 34.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(8, 20, 'Prateleira 3');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('TECLADO', 'EMPRESA 5', 'UN', 'ATIVO', '2017-03-10', 'TECLADO USB', 40.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(9, 10, 'Prateleira 3');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('CABO VGA', 'EMPRESA 6', 'UN', 'ATIVO', '2017-03-10', 'PC/NOTEBOOK', 15.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(10, 100, 'Prateleira 3');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('CD-R', 'EMPRESA X', 'UN', 'ATIVO', '2017-03-10', 'MÍDIA 700MB GRAVÁVEL', 1.50);
INSERT INTO estoque(id_produto, quantidade, locacao) values(11, 10, 'Prateleira 6');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('DVD-R', 'EMPRESA X', 'UN', 'ATIVO', '2017-03-10', 'MÍDIA 4,7GB GRAVÁVEL', 2.50);
INSERT INTO estoque(id_produto, quantidade, locacao) values(12, 20, 'Prateleira 7');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('CD-RW', 'EMPRESA X', 'UN', 'ATIVO', '2017-03-10', 'MÍDIA 700MB REGRAVÁVEL"', 600.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(13, 5, 'Prateleira 2');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('DVD-RW', 'EMPRESA X', 'UN', 'ATIVO', '2017-03-10', 'MÍDIA 4,7GB REGRAVÁVEL', 350.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(14, 5, 'Prateleira 3');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('NOTEBOOK N01', 'EMPRESA Y', 'UN', 'ATIVO', '2017-03-10', 'NOTEBOOK 1GB RAM 180GB HD', 750.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(15, 10, 'Prateleira 1');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('NOTEBOOK N02', 'EMPRESA Y', 'UN', 'ATIVO', '2017-03-10', 'NOTEBOOK 2GB RAM 360GB HD', 1020.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(16, 100, 'Prateleira 5');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('NOTEBOOK GAMER N01', 'EMPRESA Y', 'UN', 'ATIVO', '2017-03-10', 'NOTEBOOK 4GB RAM 500GB HD', 1800.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(17, 20, 'Prateleira 4');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('NOTEBOOK GAMER N02', 'EMPRESA Y', 'UN', 'ATIVO', '2017-03-10', 'NOTEBOOK 8GB RAM 1TB HD', 2500.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(18, 5, 'Prateleira 3');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('NOTEBOOK GAMER XT01', 'EMPRESA N', 'UN', 'ATIVO', '2017-03-10', 'NOTEBOOK 12GB RAM 120GB SSD 1TB HD', 3500.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(19, 5, 'Prateleira 4');
INSERT INTO produto(nome, fornecedor, medida, status, ultima_compra, descricao, preco) values('NOTEBOOK N03', 'EMPRESA Y', 'UN', 'ATIVO', '2017-03-10', 'NOTEBOOK 2GB RAM 500GB HD', 1100.00);
INSERT INTO estoque(id_produto, quantidade, locacao) values(20, 10, 'Prateleira 1');