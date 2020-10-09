using System.ComponentModel.DataAnnotations;

namespace NexcodeControls.Domain.Entities
{
    //classe abstrata inibe a possibilidade da classe  ser instanciada
    public abstract class BaseEntity //: IEquatable<Entity>
    {
        //abstract class porque será usada como herança de outras classes e não pode ser instanciada    
        //Guid: Menos performatico, porem, consegue definir e controlar o id a nivel de aplicação, transações
        //IEquatable comparar se entidades são iguais

        [Key]           // Informa que é chave primaria
        public virtual int Id { get; set; }

        //public bool Equals([AllowNull] Entity other)
        //{
        //    return Id == other.Id;
        //}
    }
}
