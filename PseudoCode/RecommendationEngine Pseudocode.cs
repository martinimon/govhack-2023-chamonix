Inputs: Passions
Inputs: PercievedSkills
Inputs: OccupationData

List<OccupationRecommendations> recommendations = {};

Iterate through each Occupation in OccupationData
{
    passionAlignment = 0;
    skillsAlignment = 0;
    
    activitiesList = Get list all activities performed in Occupation X (using say GPT4 or some other data source for each occupations)

    Iterate through each Activity in activitiesList
    {
        activityProminence = GetActivityProminenceInOccupation(activity, occupation) // Just default to 1 if this data cannot be obtained, still better than nothing.

        (activityPassionScore, activitySkillsScore) = GetUserWeight(activity, Passions, PercievedSkills)

        passionAlignment += activityProminence * activityPassionScore;
        skillsAlignment += activityProminence * activitySkillsScore;
    }

    recommendations.Add((Occupation, passionAlignment, skillsAlignment, Occupation.Pay))
}

GetUserWeight(activity, Passions, PercievedSkills)
{
    PassionScore = assess how well activity aligns with the user's Passions using some kind of system like GPT4
    PercievedSkillsScore = assess how well activity aligns with the user's PercievedSkills using some kind of system like GPT4
    return (PassionScore, PercievedSkillsScore)
}