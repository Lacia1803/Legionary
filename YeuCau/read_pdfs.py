import pypdf
import os

pdf_files = [
    "01-THONG-BAO-CUOI-KY.pdf",
    "02-DE-CUONG-CUOI-KY.pdf",
    "07-TEMPLATE-BAO-CAO.pdf"
]

for pdf_file in pdf_files:
    print(f"=== {pdf_file} ===")
    try:
        reader = pypdf.PdfReader(pdf_file)
        text = ""
        for page in reader.pages:
            text += page.extract_text() + "\n"
        print(text)
    except Exception as e:
        print(f"Error reading {pdf_file}: {e}")
    print("=" * 40 + "\n")
