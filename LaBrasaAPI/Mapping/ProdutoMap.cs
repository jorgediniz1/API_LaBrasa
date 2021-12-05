using LaBrasaAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaBrasaAPI.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {

            builder.ToTable("tb_produtos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnType("nvarchar(50)").HasColumnName("produtos");
            builder.Property(x => x.Catergoria).HasColumnType("nvarchar(10)").HasColumnName("categoria");
            builder.Property(x => x.QuantidadeEstoque).HasColumnType("numeric").HasColumnName("quantidade_estoque");
            builder.Property(x => x.QuantidadeMinima).HasColumnType("numeric").HasColumnName("quantidade_minima");
            builder.Property(x => x.QuantidadeAdicionar).HasColumnType("numeric").HasColumnName("quantidade_adicionar");
            builder.Property(x => x.PrecoCusto).HasColumnType("numeric(38,2)").HasColumnName("preco_custo");
            builder.Property(x => x.PrecoVenda).HasColumnType("numeric(38,2)").HasColumnName("preco_venda");
        }
    }
}