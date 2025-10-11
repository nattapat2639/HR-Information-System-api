using System;
using System.Collections.Generic;

namespace Hris.Domain.Entities;

public class EngagementSurvey
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Status { get; set; } = default!;
    public DateTime OpenDate { get; set; }
    public DateTime CloseDate { get; set; }

    public ICollection<EngagementSurveyMetric> Metrics { get; set; } = new List<EngagementSurveyMetric>();
}
