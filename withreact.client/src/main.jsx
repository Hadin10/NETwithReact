import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'

createRoot(document.getElementById('root')).render(
    <StrictMode>
        <div className="row">
            <h1>Allah is great</h1>
        </div>
        <App />
        <div className="footer">
            <p>Developed by Md. Nura Akram</p>
        </div>
  </StrictMode>,
)
