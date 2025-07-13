Here’s a concise and professional `README.md` for your fullstack **FoodWise PG** project, including:

* .NET Web API (Backend)
* Kotlin (Mobile App)
* React.js (Web Admin Dashboard)
* Firebase (Auth + DB)

---

```markdown
# 🍽️ FoodWise PG – Smart Meal Management System

**FoodWise PG** is a full-stack solution for Paying Guest (PG) meal tracking and management using AI demand prediction and real-time dashboards.

---

## 📦 Tech Stack

| Layer        | Technology                |
|--------------|----------------------------|
| 🧠 Backend   | .NET 6 Web API, MSSQL     |
| 📱 Mobile App | Kotlin (Android)          |
| 💻 Web Admin | React.js (with Router)    |
| ☁️ Cloud     | Firebase (Auth + Firestore + Hosting) |
| 🔍 AI Engine | Python ML Model (optional plug-in) |

---

## 🧩 Key Features

- **Role-Based Access**: PG Owners (Admins) & PG Residents (Users)
- **Admin Portal**: User management, meal confirmations, demand insights
- **Resident App**: Daily meal confirmations via mobile
- **AI Meal Prediction**: Smart estimations for grocery planning
- **Real-time Dashboard**: Live meal status view
- **Firebase Auth**: Secured login system
- **PWA Support**: App-like experience on web

---

## 📁 Project Structure

```

FoodWise-PG/
├── api/                  # ASP.NET Core Web API (REST backend)
│   ├── Controllers/
│   ├── Models/
│   ├── Services/
│   └── appsettings.json
├── mobile/               # Android App (Kotlin)
│   └── app/
├── web-dashboard/        # Admin Web Portal (React.js)
│   ├── src/
│   │   ├── pages/
│   │   ├── components/
│   │   └── App.js
├── firebase/             # Firebase Functions (Optional notifications)
│   └── index.js
├── firestore.rules       # Firestore security rules
└── README.md

````

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/PSivaMallikarjun/FoodWise-PG.git
cd FoodWise-PG
````

---

## 📦 Backend (.NET Web API)

```bash
cd api
dotnet restore
dotnet build
dotnet run
```

* API will be available at `https://localhost:5001`
* Database: MS SQL Server (update connection string in `appsettings.json`)

---

## 📱 Mobile App (Kotlin)

* Open `mobile/` in Android Studio
* Update Firebase `google-services.json`
* Run on emulator or real device

---

## 💻 Web Dashboard (React.js)

```bash
cd web-dashboard
npm install
npm start
```

* Runs at `http://localhost:3000`
* Build for production:

```bash
npm run build
serve -s build
```

---

## ☁️ Firebase Setup

1. Enable **Email/Password Auth**
2. Enable **Firestore** (in production mode)
3. Add your `firebaseConfig` to:

* `web-dashboard/.env`
* `mobile/app/google-services.json`

---

## 📊 Use Case Flow

* PG Owner registers and adds residents
* Residents login & confirm meals
* Admin sees real-time dashboard
* AI model predicts future demand
* Admin can adjust grocery orders smartly

---

## 📎 Useful Links

* 🔗 [Live Demo (Web)](https://your-deployment-url.com)
* 📱 [Mobile APK](https://your-apk-link.com)
* 💻 [GitHub Repo](https://github.com/PSivaMallikarjun/FoodWise-PG)
* ☁️ [Firebase Console](https://console.firebase.google.com/)

---

## 🙏 Contribution

Open to contributions via issues and PRs. Please follow coding best practices and maintain code modularity.

---

## 📄 License

MIT License © 2025 [P Siva Mallikarjun](https://linkedin.com/in/siva-70417418a)

```

---

<img width="1882" height="905" alt="Screenshot 2025-07-13 100530" src="https://github.com/user-attachments/assets/e0341ff6-df3a-40ed-85ba-2f6cb81b2d3b" />
<img width="1794" height="878" alt="Screenshot 2025-07-13 095009" src="https://github.com/user-attachments/assets/05757aff-2fe1-4278-bda4-3249e7a6c65b" />
<img width="1884" height="862" alt="Screenshot 2025-07-13 094958" src="https://github.com/user-attachments/assets/9792eeff-7c17-409c-96b4-0896fb338434" />
<img width="1904" height="950" alt="Screenshot 2025-07-13 094944" src="https://github.com/user-attachments/assets/3beb8426-abdb-4fb5-8959-122074453a54" />
<img width="1916" height="948" alt="Screenshot 2025-07-13 094931" src="https://github.com/user-attachments/assets/03b10afa-7d17-40cd-8d30-6736c9af592d" />
<img width="1919" height="966" alt="Screenshot 2025-07-13 093724" src="https://github.com/user-attachments/assets/ed016d4a-a4d1-4a39-bced-54213d18fe98" />

```
