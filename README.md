```markdown
# Sentimental Tech-Log & AI Career Advisor

**A professional full-stack ecosystem to track technical growth and emotional resilience.**

## 🏗 System Architecture
This project implements **Clean Architecture** to ensure high maintainability and testability.

### 1. Component Diagram (Onion Architecture)
<img width="1705" height="2057" alt="image" src="https://github.com/user-attachments/assets/782b2b0e-46cf-48e1-ab88-df4387f0d26a" />


### 2. State Machine (Log Lifecycle)
<img width="1932" height="781" alt="SentimentalTechLog_StateMachineDiagram" src="https://github.com/user-attachments/assets/85260266-fc32-456e-94f3-a2d216980089" />


### 3. Sequence Diagram (Data Flow)
<img width="1217" height="954" alt="SentimentalTechLog_SequenceDiagram" src="https://github.com/user-attachments/assets/fdcc7f1e-c4f5-4722-a38e-9f3dae523e32" />


## 🛠 Tech Stack
- **Backend:** .NET 8/9, ASP.NET Core Web API
- **AI Engine:** Python (FastAPI), NLP Transformers
- **Database:** PostgreSQL (with JSONB support)
- **DevOps:** GitHub Actions, Docker, Azure App Service

## 🚀 Key Features
- **Sentiment Analysis:** Real-time emotional tracking for developers.
- **Decoupled Architecture:** Independent scaling for AI and Web services.
- **Resilient Processing:** State-based retry mechanism for AI inference.
