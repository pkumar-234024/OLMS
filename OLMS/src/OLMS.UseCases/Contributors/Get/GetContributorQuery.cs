﻿namespace OLMS.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
