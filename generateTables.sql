CREATE TABLE recursos
(
  id_recursos INT IDENTITY NOT NULL,
  PRIMARY KEY (id_recursos)
);

CREATE TABLE instituicoes
(
  id_instituicao INT IDENTITY NOT NULL,
  designacao VARCHAR(50) NOT NULL,
  acronimo VARCHAR(10) NOT NULL,
  PRIMARY KEY (id_instituicao)
);


CREATE TABLE pessoa
(
  id_pessoa INT IDENTITY NOT NULL,
  nome VARCHAR(50) NOT NULL,
  morada VARCHAR(100) NOT NULL,
  email VARCHAR(50) NOT NULL,
  id_instituicao INT NOT NULL,
  PRIMARY KEY (id_pessoa),
  FOREIGN KEY (id_instituicao) REFERENCES instituicoes(id_instituicao)
);

CREATE TABLE laboratorios
(
  id_lab INT IDENTITY NOT NULL,
  designacao VARCHAR(50) NOT NULL,
  acronimo VARCHAR(10) NOT NULL,
  grupo VARCHAR(50) NOT NULL,
  id_instituicao INT NOT NULL,
  PRIMARY KEY (id_lab),
  FOREIGN KEY (id_instituicao) REFERENCES instituicoes(id_instituicao)
);

CREATE TABLE equipamentos
(
  designacao_PT VARCHAR(50) NOT NULL,
  designacao_EN VARCHAR(50) NOT NULL,
  data_registo DATE NOT NULL,
  num_registo INT NOT NULL,
  observacoes VARCHAR(1000) NOT NULL,
  foto_equipamento VARCHAR(200) NOT NULL,
  unidade_investigacao VARCHAR(50) NOT NULL,
  marca VARCHAR(20) NOT NULL,
  modelo VARCHAR(30) NOT NULL,
  num_serie INT NOT NULL,
  garantia INT NOT NULL,
  tipo_uso VARCHAR(20) NOT NULL,
  condicao_uso VARCHAR(20) NOT NULL,
  mobilidade VARCHAR(10) NOT NULL,
  custo_unitario FLOAT NOT NULL,
  id_lab INT NOT NULL,
  id_recursos INT NOT NULL,
  PRIMARY KEY (id_recursos),
  FOREIGN KEY (id_lab) REFERENCES laboratorios(id_lab),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos)
);

CREATE TABLE dados
(
  designacao_PT VARCHAR(50) NOT NULL,
  designacao_EN VARCHAR(50) NOT NULL,
  webpage VARCHAR(30) NOT NULL,
  observacoes VARCHAR(1000) NOT NULL,
  custo_unitario FLOAT NOT NULL,
  id_lab INT NOT NULL,
  id_recursos INT NOT NULL,
  PRIMARY KEY (id_recursos),
  FOREIGN KEY (id_lab) REFERENCES laboratorios(id_lab),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos)
);

CREATE TABLE recursos_humanos
(
  nome VARCHAR(50) NOT NULL,
  funcao VARCHAR(50) NOT NULL,
  id_lab INT NOT NULL,
  id_recursos INT NOT NULL,
  PRIMARY KEY (id_recursos),
  FOREIGN KEY (id_lab) REFERENCES laboratorios(id_lab),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos)
);

CREATE TABLE servicos
(
  id_servico INT IDENTITY NOT NULL,
  designacao VARCHAR(50) NOT NULL,
  supervisionador INT NOT NULL,
  PRIMARY KEY (id_servico),
  FOREIGN KEY (supervisionador) REFERENCES pessoa(id_pessoa)
);

CREATE TABLE formacoes
(
  designacao_PT VARCHAR(50) NOT NULL,
  designacao_EN VARCHAR(50) NOT NULL,
  tipo_formacao VARCHAR(30) NOT NULL,
  custo_unitario FLOAT NOT NULL,
  observacoes VARCHAR(1000) NOT NULL,
  id_lab INT NOT NULL,
  id_recursos INT NOT NULL,
  PRIMARY KEY (id_recursos),
  FOREIGN KEY (id_lab) REFERENCES laboratorios(id_lab),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos)
);

CREATE TABLE produtos
(
  designacao_PT VARCHAR(50) NOT NULL,
  designacao_EN VARCHAR(50) NOT NULL,
  nivel INT NOT NULL,
  tipo_produto VARCHAR(50) NOT NULL,
  webpage VARCHAR(30) NOT NULL,
  observacoes VARCHAR(1000) NOT NULL,
  custo_unitario FLOAT NOT NULL,
  id_lab INT NOT NULL,
  id_recursos INT NOT NULL,
  PRIMARY KEY (id_recursos),
  FOREIGN KEY (id_lab) REFERENCES laboratorios(id_lab),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos)
);

CREATE TABLE atribuicao
(
  id_atribuicao IDENTITY INT NOT NULL,
  id_recursos INT NOT NULL,
  id_servico INT NOT NULL,
  PRIMARY KEY (id_atribuicao),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos),
  FOREIGN KEY (id_servico) REFERENCES servicos(id_servico)
);

CREATE TABLE pedido
(
  id_pedido INT IDENTITY NOT NULL,
  order_date DATE NOT NULL,
  end_date DATE NOT NULL,
  start_date DATE NOT NULL,
  id_servico INT NOT NULL,
  id_pessoa INT NOT NULL,
  PRIMARY KEY (id_pedido),
  FOREIGN KEY (id_servico) REFERENCES servicos(id_servico),
  FOREIGN KEY (id_pessoa) REFERENCES pessoa(id_pessoa)
);

CREATE TABLE indisponibilidade
(
  start_date DATE NOT NULL,
  end_date DATE NOT NULL,
  id_pedido INT NOT NULL,
  id_recursos INT NOT NULL,
  PRIMARY KEY (id_pedido, id_recursos),
  FOREIGN KEY (id_pedido) REFERENCES pedido(id_pedido),
  FOREIGN KEY (id_recursos) REFERENCES recursos(id_recursos)
);