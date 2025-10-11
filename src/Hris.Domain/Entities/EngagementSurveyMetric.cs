using System;

namespace Hris.Domain.Entities;

public class EngagementSurveyMetric
{
    public Guid Id { get; set; }
    public Guid SurveyId { get; set; }
    public string MetricName { get; set; } = default!;
    public string Score { get; set; } = default!;
    public string Trend { get; set; } = default!;

    public EngagementSurvey? Survey { get; set; }
}
