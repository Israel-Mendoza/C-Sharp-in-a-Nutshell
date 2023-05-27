var mappables = new List<Mappable>();

mappables.Add(new Building("Palacio Nacional", UsageType.GOVERNMENT));
mappables.Add(new Building("Estadio Azteca", UsageType.ENTERTAINMENT));
mappables.Add(new Building("Torre Latinoamericana", UsageType.BUSINNES));
mappables.Add(new Building("Palacio de Bellas Artes", UsageType.ENTERTAINMENT));
mappables.Add(new UtilityLine("Main Avenue", UtilityType.GAS));
mappables.Add(new UtilityLine("Genova St", UtilityType.FIBER_OPTIC));
mappables.Add(new UtilityLine("Las Palomas Avenue", UtilityType.WATER));

foreach (var mappable in mappables)
    Mappable.MapIt(mappable);
// "properties:  {"type": "POINT", "label": "Palacio Nacional (GOVERNMENT)", "marker": "RED STAR"}" 
// "properties:  {"type": "POINT", "label": "Estadio Azteca (ENTERTAINMENT)", "marker": "GREEN TRIANGLE"}" 
// "properties:  {"type": "POINT", "label": "Torre Latinoamericana (BUSINNES)", "marker": "RED PUSH_PIN"}" 
// "properties:  {"type": "POINT", "label": "Palacio de Bellas Artes (ENTERTAINMENT)", "marker": "GREEN TRIANGLE"}" 
// "properties:  {"type": "LINE", "label": "Main Avenue (GAS)", "marker": "RED SOLID"}" 
// "properties:  {"type": "LINE", "label": "Genova St (FIBER_OPTIC)", "marker": "BLUE DOTTED"}" 
// "properties:  {"type": "LINE", "label": "Las Palomas Avenue (WATER)", "marker": "BLUE SOLID"}" 
