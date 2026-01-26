import spacy

nlp = spacy.load("es_core_news_sm")
doc = nlp("Estoy aprendiendo español con textos reales.")

for token in doc:
    print(token.text, token.lemma_, token.pos_)
