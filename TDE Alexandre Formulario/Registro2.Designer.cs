namespace TDE_Alexandre_Formulario
{
    partial class Registro2
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtobservacoes = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.erpRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bairro:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(244, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Adamantina",
            "Adolfo",
            "Aguai",
            "Aguas da Prata",
            "Aguas de Lindoia",
            "Aguas de Santa Barbara",
            "Aguas de Sao Pedro",
            "Agudos",
            "Alambari",
            "Alfredo Marcondes",
            "Altair",
            "Altinopolis",
            "Alto Alegre",
            "Aluminio",
            "Alvares Florence",
            "Alvares Machado",
            "Alvaro de Carvalho",
            "Alvinlandia",
            "Americana",
            "Americo Brasiliense",
            "Americo de Campos",
            "Amparo",
            "Analandia",
            "Andradina",
            "Angatuba",
            "Anhembi",
            "Anhumas",
            "Aparecida d\'Oeste",
            "Aparecida",
            "Apiai",
            "Aracariguama",
            "Aracatuba",
            "Aracoiaba da Serra",
            "Aramina",
            "Arandu",
            "Arapei",
            "Araraquara",
            "Araras",
            "Arco-Iris",
            "Arealva",
            "Areias",
            "Areiopolis",
            "Ariranha",
            "Artur Nogueira",
            "Aruja",
            "Aspasia",
            "Assis",
            "Atibaia",
            "Auriflama",
            "Avai",
            "Avanhandava",
            "Avare",
            "Bady Bassitt",
            "Balbinos",
            "Balsamo",
            "Bananal",
            "Barao de Antonina",
            "Barbosa",
            "Bariri",
            "Barra Bonita",
            "Barra do Chapeu",
            "Barra do Turvo",
            "Barretos",
            "Barrinha",
            "Barueri",
            "Bastos",
            "Batatais",
            "Bauru",
            "Bebedouro",
            "Bento de Abreu",
            "Bernardino de Campos",
            "Bertioga",
            "Bilac",
            "Birigui",
            "Biritiba-Mirim",
            "Boa Esperanca do Sul",
            "Bocaina",
            "Bofete",
            "Boituva",
            "Bom Jesus dos Perdoes",
            "Bom Sucesso de Itarare",
            "Bora",
            "Boraceia",
            "Borborema",
            "Borebi",
            "Botucatu",
            "Braganca Paulista",
            "Brauna",
            "Brejo Alegre",
            "Brodosqui",
            "Brotas",
            "Buri",
            "Buritama",
            "Buritizal",
            "Cabralia Paulista",
            "Cabreuva",
            "Cacapava",
            "Cachoeira Paulista",
            "Caconde",
            "Cafelandia",
            "Caiabu",
            "Caieiras",
            "Caiua",
            "Cajamar",
            "Cajati",
            "Cajobi",
            "Cajuru",
            "Campina do Monte Alegre",
            "Campinas",
            "Campo Limpo Paulista",
            "Campos Novos Paulista",
            "Campos do Jordao",
            "Cananeia",
            "Canas",
            "Candido Mota",
            "Candido Rodrigues",
            "Canitar",
            "Capao Bonito",
            "Capela do Alto",
            "Capivari",
            "Caraguatatuba",
            "Carapicuiba",
            "Cardoso",
            "Casa Branca",
            "Cassia dos Coqueiros",
            "Castilho",
            "Catanduva",
            "Catigua",
            "Cedral",
            "Cerqueira Cesar",
            "Cerquilho",
            "Cesario Lange",
            "Charqueada",
            "Chavantes",
            "Clementina",
            "Colina",
            "Colombia",
            "Conchal",
            "Conchas",
            "Cordeiropolis",
            "Coroados",
            "Coronel Macedo",
            "Corumbatai",
            "Cosmopolis",
            "Cosmorama",
            "Cotia",
            "Cravinhos",
            "Cristais Paulista",
            "Cruzalia",
            "Cruzeiro",
            "Cubatao",
            "Cunha",
            "Descalvado",
            "Diadema",
            "Dirce Reis",
            "Divinolandia",
            "Dobrada",
            "Dois Corregos",
            "Dolcinopolis",
            "Dourado",
            "Dracena",
            "Duartina",
            "Dumont",
            "Echapora",
            "Eldorado",
            "Elias Fausto",
            "Elisiario",
            "Embauba",
            "Embu",
            "Embu-Guacu",
            "Emilianopolis",
            "Engenheiro Coelho",
            "Espirito Santo do Pinhal",
            "Espirito Santo do Turvo",
            "Estiva Gerbi",
            "Estrela d\'Oeste",
            "Estrela do Norte",
            "Euclides da Cunha Paulista",
            "Fartura",
            "Fernando Prestes",
            "Fernandopolis",
            "Fernao",
            "Ferraz de Vasconcelos",
            "Flora Rica",
            "Floreal",
            "Florida Paulista",
            "Florinia",
            "Franca",
            "Francisco Morato",
            "Franco da Rocha",
            "Gabriel Monteiro",
            "Galia",
            "Garca",
            "Gastao Vidigal",
            "Gaviao Peixoto",
            "General Salgado",
            "Getulina",
            "Glicerio",
            "Guaicara",
            "Guaimbe",
            "Guaira",
            "Guapiacu",
            "Guapiara",
            "Guara",
            "Guaracai",
            "Guaraci",
            "Guarani d\'Oeste",
            "Guaranta",
            "Guararapes",
            "Guararema",
            "Guaratingueta",
            "Guarei",
            "Guariba",
            "Guaruja",
            "Guarulhos",
            "Guatapara",
            "Guzolandia",
            "Herculandia",
            "Holambra",
            "Hortolandia",
            "Iacanga",
            "Iacri",
            "Iaras",
            "Ibate",
            "Ibira",
            "Ibirarema",
            "Ibitinga",
            "Ibiuna",
            "Icem",
            "Iepe",
            "Igaracu do Tiete",
            "Igarapava",
            "Igarata",
            "Iguape",
            "Ilha Comprida",
            "Ilha Solteira",
            "Ilhabela",
            "Indaiatuba",
            "Indiana",
            "Indiapora",
            "Inubia Paulista",
            "Ipaucu",
            "Ipero",
            "Ipeuna",
            "Ipigua",
            "Iporanga",
            "Ipua",
            "Iracemapolis",
            "Irapua",
            "Irapuru",
            "Itabera",
            "Itai",
            "Itajobi",
            "Itaju",
            "Itanhaem",
            "Itaoca",
            "Itapecerica da Serra",
            "Itapetininga",
            "Itapeva",
            "Itapevi",
            "Itapira",
            "Itapirapua Paulista",
            "Itapolis",
            "Itaporanga",
            "Itapui",
            "Itapura",
            "Itaquaquecetuba",
            "Itarare",
            "Itariri",
            "Itatiba",
            "Itatinga",
            "Itirapina",
            "Itirapua",
            "Itobi",
            "Itu",
            "Itupeva",
            "Ituverava",
            "Jaborandi",
            "Jaboticabal",
            "Jacarei",
            "Jaci",
            "Jacupiranga",
            "Jaguariuna",
            "Jales",
            "Jambeiro",
            "Jandira",
            "Jardinopolis",
            "Jarinu",
            "Jau",
            "Jeriquara",
            "Joanopolis",
            "Joao Ramalho",
            "Jose Bonifacio",
            "Julio Mesquita",
            "Jumirim",
            "Jundiai",
            "Junqueiropolis",
            "Juquia",
            "Juquitiba",
            "Lagoinha",
            "Laranjal Paulista",
            "Lavinia",
            "Lavrinhas",
            "Leme",
            "Lencois Paulista",
            "Limeira",
            "Lindoia",
            "Lins",
            "Lorena",
            "Lourdes",
            "Louveira",
            "Lucelia",
            "Lucianopolis",
            "Luis Antonio",
            "Luiziania",
            "Lupercio",
            "Lutecia",
            "Macatuba",
            "Macaubal",
            "Macedonia",
            "Magda",
            "Mairinque",
            "Mairipora",
            "Manduri",
            "Maraba Paulista",
            "Maracai",
            "Marapoama",
            "Mariapolis",
            "Marilia",
            "Marinopolis",
            "Martinopolis",
            "Matao",
            "Maua",
            "Mendonca",
            "Meridiano",
            "Mesopolis",
            "Miguelopolis",
            "Mineiros do Tiete",
            "Mira Estrela",
            "Miracatu",
            "Mirandopolis",
            "Mirante do Paranapanema",
            "Mirassol",
            "Mirassolandia",
            "Mococa",
            "Mogi Guacu",
            "Moji das Cruzes",
            "Moji-Mirim",
            "Mombuca",
            "Moncoes",
            "Mongagua",
            "Monte Alegre do Sul",
            "Monte Alto",
            "Monte Aprazivel",
            "Monte Azul Paulista",
            "Monte Castelo",
            "Monte Mor",
            "Monteiro Lobato",
            "Morro Agudo",
            "Morungaba",
            "Motuca",
            "Murutinga do Sul",
            "Nantes",
            "Narandiba",
            "Natividade da Serra",
            "Nazare Paulista",
            "Neves Paulista",
            "Nhandeara",
            "Nipoa",
            "Nova Alianca",
            "Nova Campina",
            "Nova Canaa Paulista",
            "Nova Castilho",
            "Nova Europa",
            "Nova Granada",
            "Nova Guataporanga",
            "Nova Independencia",
            "Nova Luzitania",
            "Nova Odessa",
            "Novais",
            "Novo Horizonte",
            "Nuporanga",
            "Ocaucu",
            "Oleo",
            "Olimpia",
            "Onda Verde",
            "Oriente",
            "Orindiuva",
            "Orlandia",
            "Osasco",
            "Oscar Bressane",
            "Osvaldo Cruz",
            "Ourinhos",
            "Ouro Verde",
            "Ouroeste",
            "Pacaembu",
            "Palestina",
            "Palmares Paulista",
            "Palmeira d\'Oeste",
            "Palmital",
            "Panorama",
            "Paraguacu Paulista",
            "Paraibuna",
            "Paraiso",
            "Paranapanema",
            "Paranapua",
            "Parapua",
            "Pardinho",
            "Pariquera-Acu",
            "Parisi",
            "Patrocinio Paulista",
            "Pauliceia",
            "Paulinia",
            "Paulistania",
            "Paulo de Faria",
            "Pederneiras",
            "Pedra Bela",
            "Pedranopolis",
            "Pedregulho",
            "Pedreira",
            "Pedrinhas Paulista",
            "Pedro de Toledo",
            "Penapolis",
            "Pereira Barreto",
            "Pereiras",
            "Peruibe",
            "Piacatu",
            "Piedade",
            "Pilar do Sul",
            "Pindamonhangaba",
            "Pindorama",
            "Pinhalzinho",
            "Piquerobi",
            "Piquete",
            "Piracaia",
            "Piracicaba",
            "Piraju",
            "Pirajui",
            "Pirangi",
            "Pirapora do Bom Jesus",
            "Pirapozinho",
            "Pirassununga",
            "Piratininga",
            "Pitangueiras",
            "Planalto",
            "Platina",
            "Poa",
            "Poloni",
            "Pompeia",
            "Pongai",
            "Pontal",
            "Pontalinda",
            "Pontes Gestal",
            "Populina",
            "Porangaba",
            "Porto Feliz",
            "Porto Ferreira",
            "Potim",
            "Potirendaba",
            "Pracinha",
            "Pradopolis",
            "Praia Grande",
            "Pratania",
            "Presidente Alves",
            "Presidente Bernardes",
            "Presidente Epitacio",
            "Presidente Prudente",
            "Presidente Venceslau",
            "Promissao",
            "Quadra",
            "Quata",
            "Queiroz",
            "Queluz",
            "Quintana",
            "Rafard",
            "Rancharia",
            "Redencao da Serra",
            "Regente Feijo",
            "Reginopolis",
            "Registro",
            "Restinga",
            "Ribeira",
            "Ribeirao Bonito",
            "Ribeirao Branco",
            "Ribeirao Corrente",
            "Ribeirao Grande",
            "Ribeirao Pires",
            "Ribeirao Preto",
            "Ribeirao do Sul",
            "Ribeirao dos Indios",
            "Rifaina",
            "Rincao",
            "Rinopolis",
            "Rio Claro",
            "Rio Grande da Serra",
            "Rio das Pedras",
            "Riolandia",
            "Riversul",
            "Rosana",
            "Roseira",
            "Rubiacea",
            "Rubineia",
            "Sabino",
            "Sagres",
            "Sales Oliveira",
            "Sales",
            "Salesopolis",
            "Salmourao",
            "Saltinho",
            "Salto Grande",
            "Salto de Pirapora",
            "Salto",
            "Sandovalina",
            "Santa Adelia",
            "Santa Albertina",
            "Santa Barbara d\'Oeste",
            "Santa Branca",
            "Santa Clara d\'Oeste",
            "Santa Cruz da Conceicao",
            "Santa Cruz da Esperanca",
            "Santa Cruz das Palmeiras",
            "Santa Cruz do Rio Pardo",
            "Santa Ernestina",
            "Santa Fe do Sul",
            "Santa Gertrudes",
            "Santa Isabel",
            "Santa Lucia",
            "Santa Maria da Serra",
            "Santa Mercedes",
            "Santa Rita d\'Oeste",
            "Santa Rita do Passa Quatro",
            "Santa Rosa de Viterbo",
            "Santa Salete",
            "Santana da Ponte Pensa",
            "Santana de Parnaiba",
            "Santo Anastacio",
            "Santo Andre",
            "Santo Antonio da Alegria",
            "Santo Antonio de Posse",
            "Santo Antonio do Aracangua",
            "Santo Antonio do Jardim",
            "Santo Antonio do Pinhal",
            "Santo Expedito",
            "Santopolis do Aguapei",
            "Santos",
            "Sao Bento do Sapucai",
            "Sao Bernardo do Campo",
            "Sao Caetano do Sul",
            "Sao Carlos",
            "Sao Francisco",
            "Sao Joao da Boa Vista",
            "Sao Joao das Duas Pontes",
            "Sao Joao de Iracema",
            "Sao Joao do Pau d\'Alho",
            "Sao Joaquim da Barra",
            "Sao Jose da Bela Vista",
            "Sao Jose do Barreiro",
            "Sao Jose do Rio Pardo",
            "Sao Jose do Rio Preto",
            "Sao Jose dos Campos",
            "Sao Lourenco da Serra",
            "Sao Luis do Paraitinga",
            "Sao Manuel",
            "Sao Miguel Arcanjo",
            "Sao Paulo",
            "Sao Pedro do Turvo",
            "Sao Pedro",
            "Sao Roque",
            "Sao Sebastiao da Grama",
            "Sao Sebastiao",
            "Sao Simao",
            "Sao Vicente",
            "Sarapui",
            "Sarutaia",
            "Sebastianopolis do Sul",
            "Serra Azul",
            "Serra Negra",
            "Serrana",
            "Sertaozinho",
            "Sete Barras",
            "Severinia",
            "Silveiras",
            "Socorro",
            "Sorocaba",
            "Sud Mennucci",
            "Sumare",
            "Suzanapolis",
            "Suzano",
            "Tabapua",
            "Tabatinga",
            "Taboao da Serra",
            "Taciba",
            "Taguai",
            "Taiacu",
            "Taiuva",
            "Tambau",
            "Tanabi",
            "Tapirai",
            "Tapiratiba",
            "Taquaral",
            "Taquaritinga",
            "Taquarituba",
            "Taquarivai",
            "Tarabai",
            "Taruma",
            "Tatui",
            "Taubate",
            "Tejupa",
            "Teodoro Sampaio",
            "Terra Roxa",
            "Tiete",
            "Timburi",
            "Torre de Pedra",
            "Torrinha",
            "Trabiju",
            "Tremembe",
            "Tres Fronteiras",
            "Tuiuti",
            "Tupa",
            "Tupi Paulista",
            "Turiuba",
            "Turmalina",
            "Ubarana",
            "Ubatuba",
            "Ubirajara",
            "Uchoa",
            "Uniao Paulista",
            "Urania",
            "Uru",
            "Urupes",
            "Valentim Gentil",
            "Valinhos",
            "Valparaiso",
            "Vargem Grande Paulista",
            "Vargem Grande do Sul",
            "Vargem",
            "Varzea Paulista",
            "Vera Cruz",
            "Vinhedo",
            "Viradouro",
            "Vista Alegre do Alto",
            "Vitoria Brasil",
            "Votorantim",
            "Votuporanga",
            "Zacarias"});
            this.cmbCidade.Location = new System.Drawing.Point(107, 170);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.TabIndex = 10;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(107, 36);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(347, 20);
            this.txtnome.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(107, 73);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(347, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(107, 105);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(347, 20);
            this.txtBairro.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(235, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefone:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbEstado.Location = new System.Drawing.Point(333, 170);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Observações:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtobservacoes
            // 
            this.txtobservacoes.Location = new System.Drawing.Point(150, 221);
            this.txtobservacoes.Multiline = true;
            this.txtobservacoes.Name = "txtobservacoes";
            this.txtobservacoes.Size = new System.Drawing.Size(330, 114);
            this.txtobservacoes.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(299, 392);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 24;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click_1);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(154, 392);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 25;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseCompatibleTextRendering = true;
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // erpRegistro
            // 
            this.erpRegistro.ContainerControl = this;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(107, 142);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(121, 20);
            this.txtCEP.TabIndex = 26;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(333, 139);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtTelefone.TabIndex = 27;
            // 
            // Registro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = global::TDE_Alexandre_Formulario.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtobservacoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Registro2";
            this.Text = "Endereço";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtobservacoes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.ErrorProvider erpRegistro;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCEP;
    }
}

