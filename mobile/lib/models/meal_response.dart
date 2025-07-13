class MealResponse {
  final int userId;
  final String mealType;
  final DateTime responseDate;
  final bool willAttend;

  MealResponse({
    required this.userId,
    required this.mealType,
    required this.responseDate,
    required this.willAttend,
  });

  Map<String, dynamic> toJson() => {
        'userId': userId,
        'mealType': mealType,
        'responseDate': responseDate.toIso8601String(),
        'willAttend': willAttend,
      };
}
