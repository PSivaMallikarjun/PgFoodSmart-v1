import 'package:flutter/material.dart';
import '../models/meal_response.dart';
import '../services/api_service.dart';

class AlertScreen extends StatelessWidget {
  final int userId;
  final String mealType;

  const AlertScreen({super.key, required this.userId, required this.mealType});

  void _submitResponse(BuildContext context, bool willAttend) async {
    final response = MealResponse(
      userId: userId,
      mealType: mealType,
      responseDate: DateTime.now(),
      willAttend: willAttend,
    );

    final success = await ApiService.sendMealResponse(response);

    ScaffoldMessenger.of(context).showSnackBar(SnackBar(
      content: Text(success ? "Response sent!" : "Failed to send response"),
    ));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('$mealType Alert')),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text("Will you have $mealType?"),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                ElevatedButton(
                  onPressed: () => _submitResponse(context, true),
                  child: const Text("Yes"),
                ),
                const SizedBox(width: 20),
                ElevatedButton(
                  onPressed: () => _submitResponse(context, false),
                  child: const Text("No"),
                ),
              ],
            )
          ],
        ),
      ),
    );
  }
}
