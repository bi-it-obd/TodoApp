USE TodoApp;

INSERT INTO UrgencyLookup (Name, ColorRGB) VALUES
	("Low", "#757575"),
	("Normal", "#3b82b6"),
	("Medium", "#ac8e4a"),
	("High", "#ac4b5b");

INSERT INTO StatusLookup (Id, Name, ColorRGB) VALUES
	(0, "Not Started", "#2c2c2c"),
	(1, "In Progress", "#264570"),
	(2, "Done", "#256766");