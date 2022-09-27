# SGFRenaissance
Repositório do Sistema de Fluxo de Caixa - SGFRenaissance
Sistema de Fluxo de Caixa, com Títulos a Receber e Títulos a Pagar, Lançamentos Bancários, Relatórios, e visualização da DRE (Demonstrativo do Resultado do Exercício)
O Sistema possui um acesso ao banco de dados com o projeto .DAL usando um layer para salvar e editar os cadastros.
Criei também alguns cadastros fora do sistema DAL, utilizando outro acesso ao banco, fazendo o CRUD, porém não criei uma classe de conexão.
Os cadastros de títulos (receber e pagar) possuem duas tabelas para vincular o parcelamento. Parcelas a pagar e parcelas a receber.
Inclui obviamente centro de custos, tipos das despesas, status do título e etc. 
Qualquer dúvida estou a disposição. O sistema estará público para receber melhorias, e também um módulo gráfico nos relatórios também.
No projeto está adicionado o SCRIPT DO BANCO DE DADOS SQLServer, procure por Script_Backup_xx-xx-xxxx (xx-xx-xxxx é a data do script) com as últimas atualizações.
