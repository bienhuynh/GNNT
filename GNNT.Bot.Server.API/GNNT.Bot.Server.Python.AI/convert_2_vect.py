from gensim import corpora, models, similarities
import os
from pprint import pprint
import sys

if (os.path.exists("./word_dict.dict")):
    dictionary = corpora.Dictionary.load('./word_dict.dict')
    corpus = corpora.MmCorpus('./dict/corpus.mm')

with open('./text_not_remove_stop_word.txt') as f:
    mylist = f.read().splitlines()

tfidf = models.TfidfModel(corpus)

corpus_tfidf = tfidf[corpus]

lsi = models.LsiModel(corpus_tfidf, id2word=dictionary, num_topics=2)

#lsi = models.LsiModel(corpus, id2word=dictionary, num_topics=2)

doc  = sys.argv[1]
vec_bow = dictionary.doc2bow(doc.lower().split())
vec_lsi = lsi[vec_bow]
#print(vec_lsi)

index = similarities.MatrixSimilarity(lsi[corpus])

'''search quuery'''
sims = index[vec_lsi]
#pprint(sims)
sims = sorted(enumerate(sims), key=lambda item: -item[1])
#pprint(sims)
pprint(mylist[sims[0][0]])
