

using FluentNHibernate.Mapping;

public class ProfissaoMap : ClassMap<Profissao> {

public ProfissaoMap(){
  Id( p=> p.Id );
  Map( p=> p.pessoa );
  Map( p=> p.ocupacao );
  Map( p=> p.salario );
  Table("Profissoes");
}
}