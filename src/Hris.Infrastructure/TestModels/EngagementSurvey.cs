using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class EngagementSurvey
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime OpenDate { get; set; }

    public DateTime CloseDate { get; set; }

    public virtual ICollection<EngagementSurveyMetric> EngagementSurveyMetrics { get; set; } = new List<EngagementSurveyMetric>();
}
