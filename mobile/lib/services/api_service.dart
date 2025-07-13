import 'package:http/http.dart' as http;
import 'dart:convert';
import '../models/meal_response.dart';

class ApiService {
  static const String baseUrl = "http://10.0.2.2:5218/api/meal"; // For Android emulator

  static Future<bool> sendMealResponse(MealResponse response) async {
    final res = await http.post(
      Uri.parse('$baseUrl/response'),
      headers: {"Content-Type": "application/json"},
      body: jsonEncode(response.toJson()),
    );
    return res.statusCode == 200;
  }
}
