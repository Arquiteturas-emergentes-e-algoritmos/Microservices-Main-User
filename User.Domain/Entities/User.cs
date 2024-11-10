using User.Domain.Entities.Abstract;

namespace User.Domain;

public class User : Entity
{
    public Guid MedicationPlanId { get; set; } = Guid.Empty;
    public Guid GlucometerId { get; set; } = Guid.Empty;
    public void Update()
    {
    }
}
