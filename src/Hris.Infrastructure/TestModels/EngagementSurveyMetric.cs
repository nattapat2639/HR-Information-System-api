using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class EngagementSurveyMetric
{
    public Guid Id { get; set; }

    public Guid SurveyId { get; set; }

    public string MetricName { get; set; } = null!;

    public string Score { get; set; } = null!;

    public string Trend { get; set; } = null!;

    public virtual EngagementSurvey Survey { get; set; } = null!;
}
