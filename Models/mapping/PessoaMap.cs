

using FluentNHibernate.Mapping;

public class PessoaMap : ClassMap<Pessoa>
{
  public PessoaMap()
  {
    Id(p => p.Id);
    Map(p => p.nome);
    Map(p => p.idade);
    Map(p => p.endereco);
    Map(p => p.email);
    Table("Pessoas");
  }
}